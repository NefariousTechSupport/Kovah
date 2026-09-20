using System.Reflection;

namespace Kovah.Packfile
{
	public struct HavokMemberSerialization
	{
		public uint offset;
		private readonly HavokMemberAttribute attr;
		public FieldInfo field;

		public EVersion Version               => attr.Version;
		public ushort Ordinal                 => attr.Offset;
		public Type? Class                    => attr.Class;
		public Type? Enum                     => attr.Enum;
		public hkClassMember.Type Type        => attr.Type;
		public hkClassMember.Type Subtype     => attr.Subtype;
		public ushort ArraySize               => attr.ArraySize;
		public hkClassMember.FlagValues Flags => attr.Flags;


		public HavokMemberSerialization(HavokMemberAttribute attr, FieldInfo field)
		{
			this.offset = 0;
			this.attr = attr;
			this.field = field;
		}


		public uint GetSize(HavokPackfile file)
		{
			return GetSize(file, attr.Type, attr.Subtype, file.GetClassSerialization(attr.Class));
		}


		public uint GetAlignment(HavokPackfile file)
		{
			return GetAlignment(file, attr.Type, attr.Subtype, file.GetClassSerialization(attr.Class));
		}


		public static uint GetSize(HavokPackfile file, hkClassMember.Type type, hkClassMember.Type subtype, HavokClassSerialization? clazz)
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
					return GetSize(file, subtype, hkClassMember.Type.TYPE_VOID, (HavokClassSerialization?)null);
				case hkClassMember.Type.TYPE_SIMPLEARRAY:
					// alignment on 64 bit platforms bumps the size up
					return file.pointerSize * 2u;
				case hkClassMember.Type.TYPE_VARIANT:
					return file.pointerSize * 2u;
				case hkClassMember.Type.TYPE_STRUCT:
					if (clazz != null)
					{
						return clazz.ObjectSize;
					}
					else
					{
						throw new NotImplementedException("Struct without class");
					}
			}

			throw new NotImplementedException($"Type {type} and subtype {subtype} not implemented");
		}


		public static uint GetAlignment(HavokPackfile file, hkClassMember.Type type, hkClassMember.Type subtype, HavokClassSerialization? clazz)
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
					return GetAlignment(file, subtype, hkClassMember.Type.TYPE_VOID, null);
				case hkClassMember.Type.TYPE_STRUCT:
					if (clazz != null)
					{
						return clazz.Alignment;
					}
					else
					{
						throw new NotImplementedException("Struct without class");
					}
			}

			throw new NotImplementedException($"Type {type} and subtype {subtype} not implemented");
		}
	}}