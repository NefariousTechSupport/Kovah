using System.Reflection;
using Kovah.Packfile;
using Sapphire;

namespace Kovah
{
	public class HavokPackfileReader
	{
		private List<Section> sections = new List<Section>();
		private Dictionary<uint, HavokClassSerialization> classnameLookup = new Dictionary<uint, HavokClassSerialization>();
		private Dictionary<uint, object> objects = new Dictionary<uint, object>();
		private HavokPackfile file = new HavokPackfile();


		private struct Section
		{
			public uint dataOffset;
			public uint bufferSize;
			public List<LocalFixup> locals;
			public List<GlobalFixup> globals;
			public List<VirtualFixup> virtuals;
		}


		private struct LocalFixup
		{
			public uint target;
			public uint destination;
		}


		private struct GlobalFixup
		{
			public uint target;
			public uint section;
			public uint destination;
		}


		private struct VirtualFixup
		{
			public uint target;
			public uint section;
			public uint classnameOffset;
		}



		private uint DeserializeOffset(uint section, uint offset)
		{
			return sections[(int)section].dataOffset + offset;
		}


		private uint? GetFixupDestination(uint offset)
		{
			for (int s = 0; s < sections.Count; s++)
			{
				Section section = sections[s];
				if (section.dataOffset > offset || section.dataOffset + section.bufferSize < offset)
				{
					continue;
				}

				for (int f = 0; f < section.locals.Count; f++)
				{
					if (section.locals[f].target + section.dataOffset == offset)
					{
						return section.dataOffset + section.locals[f].destination;
					}
				}

				for (int f = 0; f < section.globals.Count; f++)
				{
					if (section.globals[f].target + section.dataOffset == offset)
					{
						return sections[(int)section.globals[f].section].dataOffset + section.globals[f].destination;
					}
				}
			}

			return null;
		}


		/// <summary>
		/// Loads a packfile
		/// </summary>
		public static bool Load(Stream stream, out hkRootLevelContainer? container)
		{
			StreamHelper sh = new StreamHelper(stream);
			uint magic1 = sh.ReadUInt32();
			uint magic2 = sh.ReadUInt32();
			if (magic1 != HavokPackfile.kMagicCookie1 && magic2 != HavokPackfile.kMagicCookie2)
			{
				container = null;
				return false;
			}

			sh.Seek(0x11);
			bool isLittleEndian       = sh.ReadBoolean();
			sh._endianness = isLittleEndian ? StreamHelper.Endianness.Little : StreamHelper.Endianness.Big;

			HavokPackfileReader reader = new HavokPackfileReader();

			sh.Seek(0x08);
			reader.file.userTag     = sh.ReadUInt32();
			reader.file.version     = sh.ReadUInt32();
			reader.file.pointerSize = sh.ReadByte();
			sh.ReadByte();
			reader.file.reusePadding                = sh.ReadBoolean();
			reader.file.emptyBaseClassOptimisation  = sh.ReadBoolean();

			uint sectionCount                         = sh.ReadUInt32();
			reader.file.contentSectionIndex           = sh.ReadUInt32();
			reader.file.contentSectionOffset          = sh.ReadUInt32();
			reader.file.contentClassNameSectionIndex  = sh.ReadUInt32();
			reader.file.contentClassNameSectionOffset = sh.ReadUInt32();

			string versionName = sh.ReadString();
			EVersion? metadataVersion = HavokPackfile.GetVersionEnum(versionName);
			if (metadataVersion == null)
			{
				throw new Exception($"Version {versionName} isn't supported");
			}
			reader.file.metadataVersion = metadataVersion.Value;

			sh.Seek(0x38);

			reader.file.flags                = sh.ReadUInt32();
			reader.file.maxPredicate         = sh.ReadUInt16();
			ushort predicateArraySize = sh.ReadUInt16();

			if (predicateArraySize > 0)
			{
				reader.file.predicates = sh.ReadBytes(predicateArraySize);
			}

			reader.sections = new List<Section>((int)sectionCount);
			for (int s = 0; s < sectionCount; s++)
			{
				uint sectionStart = sh.Tell();
				string sectionName = sh.ReadString();
				sh.Seek(sectionStart + 0x14);

				uint dataOffset         = sh.ReadUInt32();
				uint localFixupOffset   = dataOffset + sh.ReadUInt32();
				uint globalFixupOffset  = dataOffset + sh.ReadUInt32();
				uint virtualFixupOffset = dataOffset + sh.ReadUInt32();
				uint exportsOffset      = sh.ReadUInt32();
				uint importsOffset      = sh.ReadUInt32();
				uint bufferSize         = sh.ReadUInt32();

				uint fixupsEnd          = dataOffset + ((exportsOffset == 0xFFFFFFFF) ? importsOffset : exportsOffset);

				List<LocalFixup> locals     = new List<LocalFixup>();
				List<GlobalFixup> globals   = new List<GlobalFixup>();
				List<VirtualFixup> virtuals = new List<VirtualFixup>();

				sh.Seek(localFixupOffset);
				while (sh.Tell() < globalFixupOffset)
				{
					uint target = sh.ReadUInt32();
					if (target == 0xFFFFFFFF)
					{
						break;
					}
					locals.Add(new LocalFixup() { target = target, destination = sh.ReadUInt32() });
				}
				sh.Seek(globalFixupOffset);
				while (sh.Tell() < virtualFixupOffset)
				{
					uint target = sh.ReadUInt32();
					if (target == 0xFFFFFFFF)
					{
						break;
					}
					globals.Add(new GlobalFixup() { target = target, section = sh.ReadUInt32(), destination = sh.ReadUInt32() });
				}
				sh.Seek(virtualFixupOffset);
				while (sh.Tell() < fixupsEnd)
				{
					uint target = sh.ReadUInt32();
					if (target == 0xFFFFFFFF)
					{
						break;
					}
					virtuals.Add(new VirtualFixup() { target = target, section = sh.ReadUInt32(), classnameOffset = sh.ReadUInt32() });
				}

				sh.Seek(dataOffset);

				switch (sectionName)
				{
					case "__classnames__":
						while (sh.Tell() + 5 - dataOffset < bufferSize)
						{
							uint hash = sh.ReadUInt32();
							byte unk  = sh.ReadByte();
							uint classnameOffset = sh.Tell() - dataOffset;
							string classname = sh.ReadString();
							Type? type = hkClass.LookupClass(reader.file.metadataVersion, classname);
							if (type == null)
							{
								container = null;
								return false;
							}
							HavokClassSerialization classSerial = new HavokClassSerialization(reader.file, type);
							reader.classnameLookup.Add(classnameOffset, classSerial);
							reader.file.classes.Add(classSerial);
							classSerial.ComputeOffsets(reader.file);
						}
						break;
					case "__types__":
						// there's nothing here...
						break;
					case "__data__":
						// handled later on
						break;
					default:
						container = null;
						return false;
				}

				Section section = new Section();
				section.dataOffset = dataOffset;
				section.bufferSize = bufferSize;
				section.locals     = locals;
				section.globals    = globals;
				section.virtuals   = virtuals;
				reader.sections.Add(section);

				sh.Seek(sectionStart + 0x40);
			}

			Section contentSection = reader.sections[(int)reader.file.contentSectionIndex];

			reader.objects = new Dictionary<uint, object>();
			for (int v = 0; v < contentSection.virtuals.Count; v++)
			{
				HavokClassSerialization clazz = reader.classnameLookup[contentSection.virtuals[v].classnameOffset];

				object? obj = Activator.CreateInstance(clazz.DotNetType);
				if (obj == null)
				{
					throw new NotSupportedException($"Failed to create an instance of type {clazz.DotNetType.Name}");
				}

				reader.objects.Add(contentSection.dataOffset + contentSection.virtuals[v].target, obj);
			}

			// clone the dictionary
			Dictionary<uint, object> rootObjects = new Dictionary<uint, object>(reader.objects);
			foreach (KeyValuePair<uint, object> kvp in rootObjects)
			{
				sh.Seek(kvp.Key);
				reader.ParseObject(sh, kvp.Value);
			}

			container = null;
			foreach (object root in rootObjects.Values)
			{
				if (root is hkRootLevelContainer)
				{
					container = (hkRootLevelContainer)root;
				}
			}

			return true;
		}


		private void ParseObject(StreamHelper sh, object obj)
		{
			uint objOffset = sh.Tell();
			HavokClassSerialization clazz = file.classes.First(x => x.DotNetType == obj.GetType());

			for (int f = 0; f < clazz.Members.Count; f++)
			{
				HavokMemberSerialization member = clazz.Members[f];

				sh.Seek(objOffset + member.offset);

				member.field.SetValue(obj, ReadValue(sh, member.Class, member.Enum, member.Type, member.Subtype));
			}
		}
			}
		}


		private object? ReadValue(StreamHelper sh, Type? clazz, Type? eenum, hkClassMember.Type type, hkClassMember.Type subtype)
		{
			switch (type)
			{
				case hkClassMember.Type.TYPE_BOOL:
					return sh.ReadBoolean();
				case hkClassMember.Type.TYPE_CHAR:
					return (char)sh.ReadByte();
				case hkClassMember.Type.TYPE_INT8:
					return sh.ReadSByte();
				case hkClassMember.Type.TYPE_UINT8:
					return sh.ReadByte();
				case hkClassMember.Type.TYPE_INT16:
					return sh.ReadInt16();
				case hkClassMember.Type.TYPE_UINT16:
					return sh.ReadUInt16();
				case hkClassMember.Type.TYPE_INT32:
					return sh.ReadInt32();
				case hkClassMember.Type.TYPE_UINT32:
					return sh.ReadUInt32();
				case hkClassMember.Type.TYPE_INT64:
					return sh.ReadInt64();
				case hkClassMember.Type.TYPE_UINT64:
					return sh.ReadUInt64();
				case hkClassMember.Type.TYPE_REAL:
					return sh.ReadSingle();
				case hkClassMember.Type.TYPE_VECTOR4:
					return new Vector4(sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle());
				case hkClassMember.Type.TYPE_QUATERNION:
				case hkClassMember.Type.TYPE_ROTATION:
					return new Quaternion(sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle());
				case hkClassMember.Type.TYPE_MATRIX3:
				case hkClassMember.Type.TYPE_QSTRANSFORM:
					return new Matrix3x4(
						sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle(),
						sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle(),
						sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle()
					);
				case hkClassMember.Type.TYPE_MATRIX4:
				case hkClassMember.Type.TYPE_TRANSFORM:
					return new Matrix4x4(
						sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle(),
						sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle(),
						sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle(),
						sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle(), sh.ReadSingle()
					);
				case hkClassMember.Type.TYPE_POINTER:
				{
					uint pointerOffs = sh.Tell();
					uint? fixupDest = GetFixupDestination(pointerOffs);
					if (fixupDest == null)
					{
						return null;
					}
					switch (subtype)
					{
						case hkClassMember.Type.TYPE_STRUCT:
							return objects[fixupDest.Value];
						case hkClassMember.Type.TYPE_VOID:
							if (clazz != null)
							{
								return objects[fixupDest.Value];
							}
							else
							{
								throw new NotImplementedException("aaaa");
							}
						default:
							throw new NotImplementedException("aaaa");
					}
				}
				case hkClassMember.Type.TYPE_ARRAY:
				{
					uint arrayOffs = sh.Tell();
					uint? fixupDest = GetFixupDestination(arrayOffs);
					sh.Seek(file.pointerSize, SeekOrigin.Current);
					uint size             = sh.ReadUInt32();
					uint capacityAndFlags = sh.ReadUInt32();

					if ((capacityAndFlags & 0x80000000) == 0)
					{
						Debug.Assert((capacityAndFlags & ~0x80000000) == 0);
						return null;
					}
					else
					{
						Debug.Assert(size == (capacityAndFlags & ~0x80000000));
						Type elementType;
						switch (subtype)
						{
							case hkClassMember.Type.TYPE_BOOL:
								elementType = typeof(bool);
								break;
							case hkClassMember.Type.TYPE_CHAR:
								elementType = typeof(char);
								break;
							case hkClassMember.Type.TYPE_INT8:
								elementType = typeof(sbyte);
								break;
							case hkClassMember.Type.TYPE_UINT8:
								elementType = typeof(byte);
								break;
							case hkClassMember.Type.TYPE_INT16:
								elementType = typeof(short);
								break;
							case hkClassMember.Type.TYPE_UINT16:
								elementType = typeof(ushort);
								break;
							case hkClassMember.Type.TYPE_INT32:
								elementType = typeof(int);
								break;
							case hkClassMember.Type.TYPE_UINT32:
								elementType = typeof(uint);
								break;
							case hkClassMember.Type.TYPE_INT64:
								elementType = typeof(long);
								break;
							case hkClassMember.Type.TYPE_UINT64:
							case hkClassMember.Type.TYPE_ULONG:
								elementType = typeof(ulong);
								break;
							case hkClassMember.Type.TYPE_REAL:
								elementType = typeof(float);
								break;
							case hkClassMember.Type.TYPE_VECTOR4:
								elementType = typeof(Vector4);
								break;
							case hkClassMember.Type.TYPE_QUATERNION:
							case hkClassMember.Type.TYPE_ROTATION:
								elementType = typeof(Quaternion);
								break;
							case hkClassMember.Type.TYPE_MATRIX3:
							case hkClassMember.Type.TYPE_QSTRANSFORM:
								elementType = typeof(Matrix3x4);
								break;
							case hkClassMember.Type.TYPE_MATRIX4:
							case hkClassMember.Type.TYPE_TRANSFORM:
								elementType = typeof(Matrix4x4);
								break;
							case hkClassMember.Type.TYPE_POINTER:
							case hkClassMember.Type.TYPE_STRUCT:
								if (clazz != null)
								{
									elementType = clazz;
								}
								else
								{
									throw new NotImplementedException("Failed to determine type");
								}
								break;
							case hkClassMember.Type.TYPE_ENUM:
							case hkClassMember.Type.TYPE_FLAGS:
								if (eenum != null)
								{
									elementType = eenum;
								}
								else
								{
									throw new NotImplementedException("Failed to determine type");
								}
								break;
							case hkClassMember.Type.TYPE_VARIANT:
								elementType = typeof(object);
								break;
							case hkClassMember.Type.TYPE_CSTRING:
							case hkClassMember.Type.TYPE_STRINGPTR:
								elementType = typeof(string);
								break;
							case hkClassMember.Type.TYPE_HALF:
								elementType = typeof(Half);
								break;
							default:
								throw new NotImplementedException("Failed to determine type");
						}

						Array arr = Array.CreateInstance(elementType, size);
						uint elementSize = HavokMemberSerialization.GetSize(file, subtype, hkClassMember.Type.TYPE_VOID, file.GetClassSerialization(clazz));
						for (int a = 0; a < size; a++)
						{
							Debug.Assert(fixupDest.HasValue);

							sh.Seek(fixupDest.Value + a * elementSize);
							arr.SetValue(ReadValue(sh, clazz, eenum, subtype, hkClassMember.Type.TYPE_VOID), a);
						}
						return arr;
					}
				}
				case hkClassMember.Type.TYPE_STRUCT:
					if (clazz == null)
					{
						throw new InvalidDataException("TYPE_STRUCT with no class");
					}
					object? obj = Activator.CreateInstance(clazz);
					if (obj == null)
					{
						throw new Exception($"Failed to instantiate object of type {clazz.Name}");
					}
					objects.Add(sh.Tell(), obj);
					ParseObject(sh, obj);
					return obj;
				case hkClassMember.Type.TYPE_STRINGPTR:
				case hkClassMember.Type.TYPE_CSTRING:
				{
					uint stringOffs = sh.Tell();
					uint? fixupDest = GetFixupDestination(stringOffs);
					if (fixupDest == null)
					{
						return null;
					}
					sh.Seek(fixupDest.Value);
					return sh.ReadString();
				}
				case hkClassMember.Type.TYPE_ENUM:
				case hkClassMember.Type.TYPE_FLAGS:
					object? numeric = ReadValue(sh, clazz, eenum, subtype, hkClassMember.Type.TYPE_VOID);
					if (numeric == null)
					{
						throw new Exception("Somehow the numeric was null??");
					}
					if (eenum == null)
					{
						throw new InvalidDataException("Somehow the enum we're trying to read is null");
					}
					return file.enums[eenum].DeserializeEnum((int)Convert.ChangeType(numeric, typeof(int)));
				default:
					throw new NotImplementedException($"reading type {type} and subtype {subtype} not implemented");
			}
		}
	}
}