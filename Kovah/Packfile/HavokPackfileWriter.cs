using System.Diagnostics;
using Kovah.Packfile;
using Sapphire;

namespace Kovah
{
	public class HavokPackfileWriter
	{
		private List<Section> sections = new List<Section>();
		private Dictionary<string, uint> classnameLookup = new Dictionary<string, uint>();
		private Dictionary<object, uint> objects = new Dictionary<object, uint>();
		private HavokPackfile file = new HavokPackfile();


		private class Section
		{
			public string name;
			public StreamHelper sh;
			public List<LocalFixup> locals;
			public List<GlobalFixup> globals;
			public List<VirtualFixup> virtuals;
			public bool alignNextString;


			public Section(StreamHelper.Endianness endianness, string name)
			{
				this.name = name;
				sh       = new StreamHelper(new MemoryStream(), endianness);
				locals   = new List<LocalFixup>();
				globals  = new List<GlobalFixup>();
				virtuals = new List<VirtualFixup>();
				alignNextString = true;
			}
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
			public Type type;
		}


		private void AddLocalFixup(Section scn, uint target, uint destination)
		{
			scn.locals.Add(new LocalFixup() { target = target, destination = destination });
		}


		private void AddGlobalFixup(Section scn, uint target, Section destinationScn, uint destination)
		{
			int sectionId = sections.IndexOf(destinationScn);
			Debug.Assert(sectionId >= 0);

			scn.globals.Add(new GlobalFixup() { target = target, section = (uint)sectionId, destination = destination });
		}


		private void AddVirtualFixup(Section scn, uint target, Type type)
		{
			int sectionId = sections.IndexOf(scn);
			Debug.Assert(sectionId >= 0);

			scn.virtuals.Add(new VirtualFixup() { target = target, section = (uint)sectionId, type = type });
		}


		/// <summary>
		/// Loads a packfile
		/// </summary>
		public static bool Save(Stream stream, uint containerVersion, EVersion metadataVersion, bool is64Bit, StreamHelper.Endianness endianness, bool reusePadding, bool emptyBaseClassOptimisation, uint userTag, hkRootLevelContainer container)
		{
			StreamHelper sh = new StreamHelper(stream, endianness);
			sh.WriteUInt32(HavokPackfile.kMagicCookie1);
			sh.WriteUInt32(HavokPackfile.kMagicCookie2);

			HavokPackfileWriter writer = new HavokPackfileWriter();
			writer.file.userTag = userTag;
			writer.file.version = containerVersion;
			writer.file.metadataVersion = metadataVersion;
			writer.file.pointerSize = (byte)(is64Bit ? 8u : 4u);
			writer.file.reusePadding = reusePadding;
			writer.file.emptyBaseClassOptimisation = emptyBaseClassOptimisation;


			sh.Seek(0x08);
			sh.WriteUInt32(writer.file.userTag);
			sh.WriteUInt32(writer.file.version);
			sh.WriteByte(writer.file.pointerSize);
			sh.WriteBoolean(endianness == StreamHelper.Endianness.Little);
			sh.WriteBoolean(writer.file.reusePadding);
			sh.WriteBoolean(writer.file.emptyBaseClassOptimisation);

			// skip things to do with the sections, we've not set them up yet anyways
			sh.Seek(0x28);

			string? versionName = HavokPackfile.GetVersionName(writer.file.metadataVersion);
			if (versionName == null)
			{
				return false;
			}
			uint versionNameStart = sh.Tell();
			sh.WriteString(versionName);
			while (sh.Tell() - versionNameStart < 0x0F)
			{
				sh.WriteByte(0);
			}
			sh.WriteByte(0xFF);

			sh.Seek(0x38);

			sh.WriteUInt32(writer.file.flags);
			sh.WriteUInt16(0x15); // max perdicate
			sh.WriteUInt16(0x10); // predicate array size
			sh.WriteBytes(new byte[]{ 0x00, 0x14, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });

			Section scnClassnames = new Section(sh._endianness, "__classnames__");
			Section scnTypes      = new Section(sh._endianness, "__types__");
			Section scnData       = new Section(sh._endianness, "__data__");
			writer.sections.Add(scnClassnames);
			writer.sections.Add(scnTypes);
			writer.sections.Add(scnData);

			writer.WriteObject(scnData, container, true);

			// __classnames__ section
			writer.BuildClassnamesSection(scnClassnames);

			// writing out the sections
			for (int s = 0; s < writer.sections.Count; s++)
			{
				writer.WriteSectionData(sh, writer.sections[s]);
			}

			sh.Seek(0x14);
			sh.WriteInt32(writer.sections.Count);
			sh.WriteInt32(writer.sections.IndexOf(scnData));
			sh.WriteInt32(0);
			sh.WriteInt32(writer.sections.IndexOf(scnClassnames));
			sh.WriteInt32(0x4B);

			return true;
		}


		private uint Allocate(Section scn, uint size, uint alignment)
		{
			uint initialPos = scn.sh.Tell();

			scn.sh.Seek(0, SeekOrigin.End);
			scn.sh.Align(alignment);
			uint allocated = scn.sh.Tell();
			for (int b = 0; b < size; b++)
			{
				scn.sh.WriteByte(0);
			}

			scn.sh.Seek(initialPos);

			return allocated;
		}


		private void WritePlaceholderPointer(Section scn)
		{
			scn.sh.WriteUInt32(0);
			if (file.pointerSize == 8)
			{
				scn.sh.WriteUInt32(0);
			}
		}


		private void BuildClassnamesSection(Section scn)
		{
			classnameLookup = new Dictionary<string, uint>();
			List<string> classnames = new List<string>();
			classnames.Add(nameof(hkClass));
			classnames.Add(nameof(hkClassMember));
			classnames.Add(nameof(hkClassEnum));
			classnames.Add(nameof(hkClassEnumItem));
			classnames.Add(nameof(hkRootLevelContainer));
			foreach (object obj in objects.Keys)
			{
				if (obj is hkBaseObject)
				{
					Type t = obj.GetType();
					if (!classnames.Contains(t.Name))
					{
						classnames.Add(t.Name);
					}
				}
			}

			for (int i = 0; i < classnames.Count; i++)
			{
				uint hash = 0x00; // algorithm unknown
				byte unk  = 0x09;
				scn.sh.WriteUInt32(hash);
				scn.sh.WriteByte(unk);
				classnameLookup.Add(classnames[i], scn.sh.Tell());
				scn.sh.WriteString(classnames[i]);
			}
		}


		private void WriteSectionData(StreamHelper sh, Section scn)
		{
			// likely version specific
			uint sectionsEnd = 0x50 + (uint)sections.Count * 0x40;

			uint headerStart = sh.Tell();
			sh.Seek(0, SeekOrigin.End);
			uint dataOffset = Math.Max(sh.Tell(), sectionsEnd);

			scn.sh.BaseStream.Flush();
			byte[] data = new byte[scn.sh.BaseStream.Length];
			scn.sh.Seek(0);
			scn.sh.Read(data);

			sh.Seek(dataOffset);
			sh.WriteBytes(data);
			while (sh.Tell() % 0x10 != 0)
			{
				sh.WriteByte(0xFF);
			}

			uint localFixupOffset = sh.Tell() - dataOffset;
			for (int l = 0; l < scn.locals.Count; l++)
			{
				sh.WriteUInt32(scn.locals[l].target);
				sh.WriteUInt32(scn.locals[l].destination);
			}
			while (sh.Tell() % 0x10 != 0)
			{
				sh.WriteUInt32(0xFFFFFFFF);
			}

			uint globalFixupOffset = sh.Tell() - dataOffset;
			for (int g = 0; g < scn.globals.Count; g++)
			{
				// Not to self: these aren't actually used yet, this code is
				// untested
				sh.WriteUInt32(scn.globals[g].target);
				sh.WriteUInt32(scn.globals[g].section);
				sh.WriteUInt32(scn.globals[g].destination);
			}
			while (sh.Tell() % 0x10 != 0)
			{
				sh.WriteUInt32(0xFFFFFFFF);
			}

			uint virtualFixupOffset = sh.Tell() - dataOffset;
			for (int v = 0; v < scn.virtuals.Count; v++)
			{
				string classname = scn.virtuals[v].type.Name;
				Debug.Assert(classnameLookup.ContainsKey(classname));

				sh.WriteUInt32(scn.virtuals[v].target);
				sh.WriteUInt32(scn.virtuals[v].section);
				sh.WriteUInt32(classnameLookup[classname]);
			}
			while (sh.Tell() % 0x10 != 0)
			{
				sh.WriteUInt32(0xFFFFFFFF);
			}

			// TODO: understand what the exports and imports are for
			uint exportsOffset = sh.Tell() - dataOffset;
			uint importsOffset = sh.Tell() - dataOffset;
			uint bufferSize    = sh.Tell() - dataOffset;

			sh.Seek(headerStart);
			sh.WriteString(scn.name);
			while (sh.Tell() - headerStart < 0x13)
			{
				sh.WriteByte(0);
			}
			sh.WriteByte(0xFF);

			sh.WriteUInt32(dataOffset);
			sh.WriteUInt32(localFixupOffset);
			sh.WriteUInt32(globalFixupOffset);
			sh.WriteUInt32(virtualFixupOffset);
			sh.WriteUInt32(exportsOffset);
			sh.WriteUInt32(importsOffset);
			sh.WriteUInt32(bufferSize);
			sh.WriteUInt64(0xFFFFFFFFFFFFFFFF);
			sh.WriteUInt64(0xFFFFFFFFFFFFFFFF);
		}


		private uint WriteObject(Section scn, object obj, bool allocate)
		{
			HavokClassSerialization? clazz = file.GetClassSerialization(obj.GetType());
			Debug.Assert(clazz != null);

			uint objOffset = scn.sh.Tell();
			if (allocate)
			{
				objOffset = Allocate(scn, clazz.ObjectSize, clazz.Alignment);
				scn.sh.Seek(objOffset);
			}
			objects.Add(obj, objOffset);


			if (obj is hkBaseObject)
			{
				// Leave space for a vtable
				WritePlaceholderPointer(scn);
				AddVirtualFixup(scn, objOffset, obj.GetType());
			}
			for (int f = 0; f < clazz.Members.Count; f++)
			{
				HavokMemberSerialization member = clazz.Members[f];
				if ((member.Flags & hkClassMember.FlagValues.SERIALIZE_IGNORED) != 0)
				{
					continue;
				}

				scn.sh.Seek(objOffset + member.offset);

				object? value = member.field.GetValue(obj);
				WriteValue(scn, member.Class, member.Enum, member.Type, member.Subtype, value, false);
			}
			return objOffset;
		}


		private void WriteValue(Section scn, Type? clazz, Type? eenum, hkClassMember.Type type, hkClassMember.Type subtype, object? value, bool isArrayElement)
		{
			switch (type)
			{
				case hkClassMember.Type.TYPE_BOOL:
					Debug.Assert(value != null);
					scn.sh.WriteBoolean((bool)value);
					break;
				case hkClassMember.Type.TYPE_CHAR:
					Debug.Assert(value != null);
					scn.sh.WriteByte((byte)(char)value);
					break;
				case hkClassMember.Type.TYPE_INT8:
					Debug.Assert(value != null);
					scn.sh.WriteSByte((sbyte)value);
					break;
				case hkClassMember.Type.TYPE_UINT8:
					Debug.Assert(value != null);
					scn.sh.WriteByte((byte)value);
					break;
				case hkClassMember.Type.TYPE_INT16:
					Debug.Assert(value != null);
					scn.sh.WriteInt16((short)value);
					break;
				case hkClassMember.Type.TYPE_UINT16:
					Debug.Assert(value != null);
					scn.sh.WriteUInt16((ushort)value);
					break;
				case hkClassMember.Type.TYPE_INT32:
					Debug.Assert(value != null);
					scn.sh.WriteInt32((int)value);
					break;
				case hkClassMember.Type.TYPE_UINT32:
					Debug.Assert(value != null);
					scn.sh.WriteUInt32((uint)value);
					break;
				case hkClassMember.Type.TYPE_INT64:
					Debug.Assert(value != null);
					scn.sh.WriteInt64((long)value);
					break;
				case hkClassMember.Type.TYPE_UINT64:
					Debug.Assert(value != null);
					scn.sh.WriteUInt64((ulong)value);
					break;
				case hkClassMember.Type.TYPE_REAL:
					Debug.Assert(value != null);
					scn.sh.WriteSingle((float)value);
					break;
				case hkClassMember.Type.TYPE_VECTOR4:
					Debug.Assert(value != null);
					scn.sh.WriteStruct((Vector4)value);
					break;
				case hkClassMember.Type.TYPE_QUATERNION:
				case hkClassMember.Type.TYPE_ROTATION:
					Debug.Assert(value != null);
					scn.sh.WriteStruct((Quaternion)value);
					break;
				case hkClassMember.Type.TYPE_MATRIX3:
				case hkClassMember.Type.TYPE_QSTRANSFORM:
					Debug.Assert(value != null);
					scn.sh.WriteStruct((Matrix3x4)value);
					break;
				case hkClassMember.Type.TYPE_MATRIX4:
				case hkClassMember.Type.TYPE_TRANSFORM:
					Debug.Assert(value != null);
					scn.sh.WriteStruct((Matrix4x4)value);
					break;
				case hkClassMember.Type.TYPE_POINTER:
				{
					uint pointerOffs = scn.sh.Tell();
					WritePlaceholderPointer(scn);

					uint pointer = 0;
					bool isObject;

					switch (subtype)
					{
						case hkClassMember.Type.TYPE_STRUCT:
							isObject = true;
							break;
						case hkClassMember.Type.TYPE_VOID:
							if (clazz != null)
							{
								isObject = true;
							}
							else
							{
								throw new NotImplementedException("aaaa");
							}
							break;
						default:
							throw new NotImplementedException("aaaa");
					}

					if (isObject && value != null)
					{
						if (!objects.TryGetValue(value, out pointer))
						{
							pointer = WriteObject(scn, value, true);
						}
					}

					if (pointer != 0)
					{
						AddLocalFixup(scn, pointerOffs, pointer);
					}

					break;
				}
				case hkClassMember.Type.TYPE_ARRAY:
				{
					uint arrayOffs = scn.sh.Tell();

					WritePlaceholderPointer(scn);

					if (value == null)
					{
						scn.sh.WriteUInt32(0);
						scn.sh.WriteUInt32(0);
					}
					else
					{
						Array array = (Array)value;
						scn.sh.WriteUInt32((uint)array.GetLength(0));
						scn.sh.WriteUInt32((uint)array.GetLength(0) | 0x80000000);

						uint elementSize  = HavokMemberSerialization.GetSize(file, subtype, hkClassMember.Type.TYPE_VOID, file.GetClassSerialization(clazz));
						uint elementAlign = HavokMemberSerialization.GetAlignment(file, subtype, hkClassMember.Type.TYPE_VOID, file.GetClassSerialization(clazz));
						uint arrayData = Allocate(scn, elementSize * (uint)array.GetLength(0), Math.Max(0x10, elementAlign));

						scn.alignNextString = false;

						for (int a = 0; a < array.GetLength(0); a++)
						{
							scn.sh.Seek(arrayData + a * elementSize);
							WriteValue(scn, clazz, eenum, subtype, hkClassMember.Type.TYPE_VOID, array.GetValue(a), true);
						}

						scn.alignNextString = true;

						AddLocalFixup(scn, arrayOffs, arrayData);
					}

					break;
				}
				case hkClassMember.Type.TYPE_STRUCT:
					if (clazz == null)
					{
						throw new InvalidDataException("TYPE_STRUCT with no class");
					}
					Debug.Assert(value != null);
					WriteObject(scn, value, false);
					break;
				case hkClassMember.Type.TYPE_STRINGPTR:
				case hkClassMember.Type.TYPE_CSTRING:
				{
					Debug.Assert(value is null || value is string);

					uint stringOffs = scn.sh.Tell();
					WritePlaceholderPointer(scn);

					// Copied from kishimisu
					byte alignment = 2;
					if (scn.alignNextString && !isArrayElement)
					{
						alignment = 16;
					}
					scn.alignNextString = true;

					if (value != null)
					{
						string strValue = (string)value;
						uint strlen = (uint)strValue.Length + 1;
						uint pointerStr = Allocate(scn, StreamHelper.Align(strlen, alignment), alignment);
						scn.sh.Seek(pointerStr);
						scn.sh.WriteString(strValue);
						AddLocalFixup(scn, stringOffs, pointerStr);
					}
					break;
				}
				case hkClassMember.Type.TYPE_ENUM:
				case hkClassMember.Type.TYPE_FLAGS:
					if (eenum == null)
					{
						throw new InvalidDataException("Somehow the enum we're trying to write is null");
					}
					Debug.Assert(value != null);
					int numeric = file.enums[eenum].SerializeEnum(value);
					Type targetType;
					switch (subtype)
					{
						case hkClassMember.Type.TYPE_INT8:
							targetType = typeof(sbyte);
							break;
						case hkClassMember.Type.TYPE_UINT8:
							targetType = typeof(byte);
							break;
						case hkClassMember.Type.TYPE_INT16:
							targetType = typeof(short);
							break;
						case hkClassMember.Type.TYPE_UINT16:
							targetType = typeof(ushort);
							break;
						case hkClassMember.Type.TYPE_INT32:
							targetType = typeof(int);
							break;
						case hkClassMember.Type.TYPE_UINT32:
							targetType = typeof(uint);
							break;
						case hkClassMember.Type.TYPE_INT64:
							targetType = typeof(long);
							break;
						case hkClassMember.Type.TYPE_UINT64:
							targetType = typeof(ulong);
							break;
						default:
							throw new InvalidCastException($"Unable to cast enum {eenum.FullName} to {subtype}");
					}
					WriteValue(scn, clazz, eenum, subtype, hkClassMember.Type.TYPE_VOID, Convert.ChangeType(numeric, targetType), false);
					break;
				default:
					throw new NotImplementedException($"writing type {type} and subtype {subtype} not implemented");
			}
		}
	}
}
