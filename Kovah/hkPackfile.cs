using System.Collections;
using System.Diagnostics;
using System.Reflection;
using Sapphire;

namespace Kovah
{
	public static class hkPackfile
	{
		private const uint kMagicCookie1 = 0x57E0E057;
		private const uint kMagicCookie2 = 0x10C0C010;


		private struct HavokFile
		{
			public uint userTag;
			public uint version;
			public byte pointerSize;
			public bool reusePadding;
			public bool emptyBaseClassOptimisation;
			public uint contentSectionIndex;
			public uint contentSectionOffset;
			public uint contentClassNameSectionIndex;
			public uint contentClassNameSectionOffset;
			public EVersion metadataVersion;
			public uint flags;
			public ushort maxPredicate;
			public byte[]? predicates;
			public List<Section> sections;
			public Dictionary<uint, HavokClassSerialization> classLookup;
			public List<HavokClassSerialization> classes;
			public Dictionary<Type, HavokEnumSerialization> enums;
			public hkRootLevelContainer? container;
			public Dictionary<uint, object> objects;
		}


		private struct Section
		{
			public uint dataOffset;
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


		private class HavokClassSerialization
		{
			public Type type;
			public HavokClassSerialization? parent;
			public uint objectSize;
			public uint alignment;
			public List<HavokMemberSerialization> members;
			private bool computed;


			public HavokClassSerialization(ref HavokFile file, Type type)
			{
				this.type = type;
				this.parent = GetClassSerialization(ref file, type.BaseType);
				this.objectSize = 1;
				this.members = new List<HavokMemberSerialization>();
				this.computed = false;


				FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

				for (int f = 0; f < fields.Length; f++)
				{
					IEnumerable<HavokMemberAttribute> attrs = fields[f].GetCustomAttributes<HavokMemberAttribute>();

					foreach(HavokMemberAttribute attr in attrs)
					{
						if (attr.Version == file.metadataVersion)
						{
							HavokMemberSerialization member = new HavokMemberSerialization();
							member.offset = 0;
							member.attr = attr;
							member.field = fields[f];
							members.Add(member);

							if (attr.Enum != null)
							{
								if (!file.enums.ContainsKey(attr.Enum))
								{
									file.enums.Add(attr.Enum, new HavokEnumSerialization(ref file, attr.Enum));
								}
							}
							break;
						}
					}
				}


				members = members.OrderBy(x => x.attr.Offset).ToList();
			}


			private uint GetNextFieldStart(ref HavokFile file)
			{
				if (members.Count > 0)
				{
					return members.Last().offset + members.Last().GetSize(ref file);
				}

				if (parent != null)
				{
					return parent.GetNextFieldStart(ref file);
				}

				return file.emptyBaseClassOptimisation ? 0u : 1u;
			}


			public void ComputeOffsets(ref HavokFile file)
			{
				if (computed)
				{
					return;
				}
				computed = true;

				uint head = 0;
				uint workingAlignment = 0;

				if (parent != null)
				{
					parent.ComputeOffsets(ref file);
					head = parent.objectSize;
					workingAlignment = parent.alignment;
				}

				if (file.reusePadding)
				{
					head = GetNextFieldStart(ref file);
				}

				for (int m = 0; m < members.Count; m++)
				{
					HavokMemberSerialization member = members[m];
					member.offset = StreamHelper.Align(head, member.GetAlignment(ref file));
					workingAlignment = Math.Max(workingAlignment, member.GetAlignment(ref file));
					head += member.GetSize(ref file);
					members[m] = member;
				}

				objectSize = Math.Max(1, head);
				alignment = Math.Max(1, workingAlignment);
			}
		}

		private struct HavokMemberSerialization
		{
			public uint offset;
			public HavokMemberAttribute attr;
			public FieldInfo field;


			public uint GetSize(ref HavokFile file)
			{
				return GetSize(ref file, attr.Type, attr.Subtype, GetClassSerialization(ref file, attr.Class));
			}


			public uint GetAlignment(ref HavokFile file)
			{
				return GetAlignment(ref file, attr.Type, attr.Subtype, GetClassSerialization(ref file, attr.Class));
			}


			public static uint GetSize(ref HavokFile file, hkClassMember.Type type, hkClassMember.Type subtype, HavokClassSerialization? clazz)
			{
				switch (type)
				{
					case hkClassMember.Type.TYPE_BOOL:
					case hkClassMember.Type.TYPE_CHAR:
					case hkClassMember.Type.TYPE_INT8:
					case hkClassMember.Type.TYPE_UINT8:
						return 1;
					case hkClassMember.Type.TYPE_INT16:
					case hkClassMember.Type.TYPE_UINT16:
					case hkClassMember.Type.TYPE_HALF:
						return 2;
					case hkClassMember.Type.TYPE_INT32:
					case hkClassMember.Type.TYPE_UINT32:
					case hkClassMember.Type.TYPE_REAL:
						return 4;
					case hkClassMember.Type.TYPE_INT64:
					case hkClassMember.Type.TYPE_UINT64:
					case hkClassMember.Type.TYPE_ULONG:
						return 8;
					case hkClassMember.Type.TYPE_VECTOR4:
					case hkClassMember.Type.TYPE_QUATERNION:
					case hkClassMember.Type.TYPE_ROTATION:
						return 0x10;
					case hkClassMember.Type.TYPE_MATRIX3:
					case hkClassMember.Type.TYPE_QSTRANSFORM:
						return 0x30;
					case hkClassMember.Type.TYPE_MATRIX4:
						return 0x40;
					case hkClassMember.Type.TYPE_POINTER:
					case hkClassMember.Type.TYPE_FUNCTIONPOINTER:
					case hkClassMember.Type.TYPE_CSTRING:
					case hkClassMember.Type.TYPE_STRINGPTR:
					case hkClassMember.Type.TYPE_RELARRAY:
						return file.pointerSize;
					case hkClassMember.Type.TYPE_ARRAY:
						return file.pointerSize + 8u;
					case hkClassMember.Type.TYPE_ENUM:
					case hkClassMember.Type.TYPE_FLAGS:
						return GetSize(ref file, subtype, hkClassMember.Type.TYPE_VOID, (HavokClassSerialization?)null);
					case hkClassMember.Type.TYPE_SIMPLEARRAY:
						// alignment on 64 bit platforms bumps the size up
						return file.pointerSize * 2u;
					case hkClassMember.Type.TYPE_VARIANT:
						return file.pointerSize * 2u;
					case hkClassMember.Type.TYPE_STRUCT:
						if (clazz != null)
						{
							return clazz.objectSize;
						}
						else
						{
							throw new NotImplementedException("Struct without class");
						}
				}

				throw new NotImplementedException($"Type {type} and subtype {subtype} not implemented");
			}


			public static uint GetAlignment(ref HavokFile file, hkClassMember.Type type, hkClassMember.Type subtype, HavokClassSerialization? clazz)
			{
				switch (type)
				{
					case hkClassMember.Type.TYPE_BOOL:
					case hkClassMember.Type.TYPE_CHAR:
					case hkClassMember.Type.TYPE_INT8:
					case hkClassMember.Type.TYPE_UINT8:
						return 1;
					case hkClassMember.Type.TYPE_INT16:
					case hkClassMember.Type.TYPE_UINT16:
					case hkClassMember.Type.TYPE_HALF:
						return 2;
					case hkClassMember.Type.TYPE_INT32:
					case hkClassMember.Type.TYPE_UINT32:
					case hkClassMember.Type.TYPE_REAL:
						return 4;
					case hkClassMember.Type.TYPE_INT64:
					case hkClassMember.Type.TYPE_UINT64:
					case hkClassMember.Type.TYPE_ULONG:
						return 8;
					case hkClassMember.Type.TYPE_VECTOR4:
					case hkClassMember.Type.TYPE_QUATERNION:
					case hkClassMember.Type.TYPE_ROTATION:
					case hkClassMember.Type.TYPE_MATRIX3:
					case hkClassMember.Type.TYPE_QSTRANSFORM:
					case hkClassMember.Type.TYPE_MATRIX4:
						return 0x10;
					case hkClassMember.Type.TYPE_POINTER:
					case hkClassMember.Type.TYPE_FUNCTIONPOINTER:
					case hkClassMember.Type.TYPE_CSTRING:
					case hkClassMember.Type.TYPE_STRINGPTR:
					case hkClassMember.Type.TYPE_RELARRAY:
					case hkClassMember.Type.TYPE_ARRAY:
					case hkClassMember.Type.TYPE_SIMPLEARRAY:
					case hkClassMember.Type.TYPE_VARIANT:
						return file.pointerSize;
					case hkClassMember.Type.TYPE_ENUM:
					case hkClassMember.Type.TYPE_FLAGS:
						return GetAlignment(ref file, subtype, hkClassMember.Type.TYPE_VOID, null);
					case hkClassMember.Type.TYPE_STRUCT:
						if (clazz != null)
						{
							return clazz.alignment;
						}
						else
						{
							throw new NotImplementedException("Struct without class");
						}
				}

				throw new NotImplementedException($"Type {type} and subtype {subtype} not implemented");
			}
		}


		private struct HavokEnumSerialization
		{
			public Type type;
			private List<string> names;
			private List<int> serialValues;
			private List<int> realValues;


			public HavokEnumSerialization(ref HavokFile file, Type type)
			{
				this.type = type;
				this.names = new List<string>();
				this.serialValues = new List<int>();
				this.realValues = new List<int>();


				string[] names  = Enum.GetNames(type);
				Array values = Enum.GetValues(type);

				for (int i = 0; i < names.Length; i++)
				{
					foreach (HavokEnumItemAttribute attr in type.GetField(names[i])!.GetCustomAttributes<HavokEnumItemAttribute>())
					{
						if (attr.Version == file.metadataVersion)
						{
							this.names.Add(names[i]);
							this.serialValues.Add(attr.Value);
							this.realValues.Add((int)values.GetValue(i)!);
							break;
						}
					}
				}
			}


			public object? DeserializeEnum(int value)
			{
				bool isFlags = type.GetCustomAttribute<FlagsAttribute>() != null;

				int intValue = 0;

				for (int i = 0; i < serialValues.Count; i++)
				{
					if (isFlags)
					{
						bool match = (value & serialValues[i]) != 0;
						if (match)
						{
							intValue |= realValues[i];
						}
					}
					else
					{
						bool match = value == serialValues[i];
						if (match)
						{
							intValue = realValues[i];
							break;
						}
					}
				}

				return Enum.ToObject(type, intValue);
			}
		}


		private static readonly (string name, EVersion version)[] kVersionLookup =
		{
			("Havok-7.1.0-r1",          EVersion.Havok_7_1_0_r1),
			("hk_2011.2.0-r1",          EVersion.hk_2011_2_0_r1),
			("hk_2012.1.0-r1",          EVersion.hk_2012_1_0_r1),
			("hk_2013.1.0-r1",          EVersion.hk_2013_1_0_r1),
			("hk_2014.1.0-r1",          EVersion.hk_2014_1_0_r1),
		};


		private static EVersion? GetVersionEnum(string name)
		{
			for (int v = 0; v < kVersionLookup.Length; v++)
			{
				if (kVersionLookup[v].name == name)
				{
					return kVersionLookup[v].version;
				}
			}

			return null;
		}


		private static string? GetVersionName(EVersion version)
		{
			for (int v = 0; v < kVersionLookup.Length; v++)
			{
				if (kVersionLookup[v].version == version)
				{
					return kVersionLookup[v].name;
				}
			}

			return null;
		}


		private static uint DeserializeOffset(ref HavokFile file, uint section, uint offset)
		{
			return file.sections[(int)section].dataOffset + offset;
		}


		private static uint? GetFixupDestination(ref HavokFile file, uint offset)
		{
			for (int s = 0; s < file.sections.Count; s++)
			{
				Section section = file.sections[s];
				if (section.dataOffset > offset)
				{
					break;
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
						return file.sections[(int)section.globals[f].section].dataOffset + section.globals[f].destination;
					}
				}
			}

			return null;
		}


		private static HavokClassSerialization? GetClassSerialization(ref HavokFile file, Type? clazz)
		{
			if (clazz == typeof(object))
			{
				return null;
			}

			HavokClassSerialization? classSerialization = null;
			if (clazz != null)
			{
				classSerialization = file.classes.FirstOrDefault(x => x.type == clazz);
				if (classSerialization == null)
				{
					classSerialization = new HavokClassSerialization(ref file, clazz);
					file.classes.Add(classSerialization);
					classSerialization.ComputeOffsets(ref file);
				}
			}
			return classSerialization;
		}


		/// <summary>
		/// Loads a packfile
		/// </summary>
		public static bool Load(Stream stream, out hkRootLevelContainer? container)
		{
			StreamHelper sh = new StreamHelper(stream);
			uint magic1 = sh.ReadUInt32();
			uint magic2 = sh.ReadUInt32();
			if (magic1 != kMagicCookie1 && magic2 != kMagicCookie2)
			{
				container = null;
				return false;
			}

			sh.Seek(0x11);
			bool isLittleEndian       = sh.ReadBoolean();
			sh._endianness = isLittleEndian ? StreamHelper.Endianness.Little : StreamHelper.Endianness.Big;

			HavokFile file = new HavokFile();
			file.container = null;
			file.classLookup = new Dictionary<uint, HavokClassSerialization>();
			file.classes = new List<HavokClassSerialization>();
			file.enums = new Dictionary<Type, HavokEnumSerialization>();

			sh.Seek(0x08);
			file.userTag              = sh.ReadUInt32();
			file.version              = sh.ReadUInt32();
			file.pointerSize          = sh.ReadByte();
			sh.ReadByte();
			file.reusePadding         = sh.ReadBoolean();
			file.emptyBaseClassOptimisation  = sh.ReadBoolean();

			uint sectionCount                  = sh.ReadUInt32();
			file.contentSectionIndex           = sh.ReadUInt32();
			file.contentSectionOffset          = sh.ReadUInt32();
			file.contentClassNameSectionIndex  = sh.ReadUInt32();
			file.contentClassNameSectionOffset = sh.ReadUInt32();

			string versionName = sh.ReadString();
			EVersion? metadataVersion = GetVersionEnum(versionName);
			if (metadataVersion == null)
			{
				throw new Exception($"Version {versionName} isn't supported");
			}
			file.metadataVersion = metadataVersion.Value;

			sh.Seek(0x38);

			file.flags                = sh.ReadUInt32();
			file.maxPredicate         = sh.ReadUInt16();
			ushort predicateArraySize = sh.ReadUInt16();

			if (predicateArraySize > 0)
			{
				file.predicates = sh.ReadBytes(predicateArraySize);
			}

			file.sections = new List<Section>((int)sectionCount);
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
							Type? type = hkClass.LookupClass(file.metadataVersion, classname);
							if (type == null)
							{
								container = null;
								return false;
							}
							HavokClassSerialization classSerial = new HavokClassSerialization(ref file, type);
							file.classLookup.Add(classnameOffset, classSerial);
							file.classes.Add(classSerial);
							classSerial.ComputeOffsets(ref file);
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
				section.locals     = locals;
				section.globals    = globals;
				section.virtuals   = virtuals;
				file.sections.Add(section);

				sh.Seek(sectionStart + 0x40);
			}

			Section contentSection = file.sections[(int)file.contentSectionIndex];

			file.objects = new Dictionary<uint, object>();
			for (int v = 0; v < contentSection.virtuals.Count; v++)
			{
				HavokClassSerialization clazz = file.classLookup[contentSection.virtuals[v].classnameOffset];

				object? obj = Activator.CreateInstance(clazz.type);
				if (obj == null)
				{
					throw new NotSupportedException($"Failed to create an instance of type {clazz.type.Name}");
				}

				file.objects.Add(contentSection.dataOffset + contentSection.virtuals[v].target, obj);
			}

			// clone the dictionary
			Dictionary<uint, object> rootObjects = new Dictionary<uint, object>(file.objects);
			foreach (KeyValuePair<uint, object> kvp in rootObjects)
			{
				sh.Seek(kvp.Key);
				ParseObject(ref file, sh, kvp.Value);
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


		private static void ParseObject(ref HavokFile file, StreamHelper sh, object obj)
		{
			HavokClassSerialization clazz = file.classes.First(x => x.type == obj.GetType());

			uint objOffset = sh.Tell();
			for (int f = 0; f < clazz.members.Count; f++)
			{
				sh.Seek(objOffset + clazz.members[f].offset);

				HavokMemberAttribute attr = clazz.members[f].attr;
				clazz.members[f].field.SetValue(obj, ReadValue(ref file, sh, attr.Class, attr.Enum, attr.Type, attr.Subtype));
			}
		}


		private static object? ReadValue(ref HavokFile file, StreamHelper sh, Type? clazz, Type? eenum, hkClassMember.Type type, hkClassMember.Type subtype)
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
					uint? fixupDest = GetFixupDestination(ref file, pointerOffs);
					if (fixupDest == null)
					{
						return null;
					}
					switch (subtype)
					{
						case hkClassMember.Type.TYPE_STRUCT:
							return file.objects[fixupDest.Value];
						case hkClassMember.Type.TYPE_VOID:
							if (clazz != null)
							{
								return file.objects[fixupDest.Value];
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
					uint? fixupDest = GetFixupDestination(ref file, arrayOffs);
					if (fixupDest == null)
					{
						return null;
					}
					else
					{
						sh.Seek(file.pointerSize, SeekOrigin.Current);
						uint size             = sh.ReadUInt32();
						uint capacityAndFlags = sh.ReadUInt32();
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
						uint elementSize = HavokMemberSerialization.GetSize(ref file, subtype, hkClassMember.Type.TYPE_VOID, GetClassSerialization(ref file, clazz));
						for (int a = 0; a < size; a++)
						{
							sh.Seek(fixupDest.Value + a * elementSize);
							arr.SetValue(ReadValue(ref file, sh, clazz, eenum, subtype, hkClassMember.Type.TYPE_VOID), a);
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
					file.objects.Add(sh.Tell(), obj);
					ParseObject(ref file, sh, obj);
					return obj;
				case hkClassMember.Type.TYPE_STRINGPTR:
				case hkClassMember.Type.TYPE_CSTRING:
				{
					uint stringOffs = sh.Tell();
					uint? fixupDest = GetFixupDestination(ref file, stringOffs);
					if (fixupDest == null)
					{
						return null;
					}
					sh.Seek(fixupDest.Value);
					return sh.ReadString();
				}
				case hkClassMember.Type.TYPE_ENUM:
				case hkClassMember.Type.TYPE_FLAGS:
					object? numeric = ReadValue(ref file, sh, clazz, eenum, subtype, hkClassMember.Type.TYPE_VOID);
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