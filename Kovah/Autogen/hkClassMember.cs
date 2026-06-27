namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkClassMember
	{
		public enum Type : int
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			TYPE_VOID,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			TYPE_BOOL,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			TYPE_CHAR,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			TYPE_INT8,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			TYPE_UINT8,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			TYPE_INT16,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 6)]
			TYPE_UINT16,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 7)]
			TYPE_INT32,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			TYPE_UINT32,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 9)]
			TYPE_INT64,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 10)]
			TYPE_UINT64,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 11)]
			TYPE_REAL,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 12)]
			TYPE_VECTOR4,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 13)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 13)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 13)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 13)]
			TYPE_QUATERNION,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 14)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 14)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 14)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 14)]
			TYPE_MATRIX3,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 15)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 15)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 15)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 15)]
			TYPE_ROTATION,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			TYPE_QSTRANSFORM,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 17)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 17)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 17)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 17)]
			TYPE_MATRIX4,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 18)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 18)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 18)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 18)]
			TYPE_TRANSFORM,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 19)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 19)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 19)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 19)]
			TYPE_ZERO,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 20)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 20)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 20)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 20)]
			TYPE_POINTER,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 21)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 21)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 21)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 21)]
			TYPE_FUNCTIONPOINTER,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 22)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 22)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 22)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 22)]
			TYPE_ARRAY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 23)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 23)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 23)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 23)]
			TYPE_INPLACEARRAY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 24)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 24)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 24)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 24)]
			TYPE_ENUM,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 25)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 25)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 25)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 25)]
			TYPE_STRUCT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 26)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 26)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 26)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 26)]
			TYPE_SIMPLEARRAY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 27)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 27)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 27)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 27)]
			TYPE_HOMOGENEOUSARRAY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 28)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 28)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 28)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 28)]
			TYPE_VARIANT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 29)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 29)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 29)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 29)]
			TYPE_CSTRING,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 30)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 30)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 30)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 30)]
			TYPE_ULONG,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 31)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 31)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 31)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 31)]
			TYPE_FLAGS,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 32)]
			TYPE_HALF,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 33)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 33)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 33)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 33)]
			TYPE_STRINGPTR,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 34)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 35)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 35)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 35)]
			TYPE_MAX,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 34)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 34)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 34)]
			TYPE_RELARRAY,
			
		}
		[Flags]
		public enum FlagValues : int
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			FLAGS_NONE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 128)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 128)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 128)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 128)]
			ALIGN_8,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 256)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 256)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 256)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 256)]
			ALIGN_16,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 512)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 512)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 512)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 512)]
			NOT_OWNED,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1024)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1024)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1024)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1024)]
			SERIALIZE_IGNORED,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2048)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2048)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2048)]
			ALIGN_32,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 256)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 256)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 256)]
			ALIGN_REAL,
			
		}
		public enum DeprecatedFlagValues : int
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			DEPRECATED_SIZE_8,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			DEPRECATED_ENUM_8,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			DEPRECATED_SIZE_16,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			DEPRECATED_ENUM_16,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 32)]
			DEPRECATED_SIZE_32,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 32)]
			DEPRECATED_ENUM_32,
			
		}
		[HavokMember(EVersion.Havok_7_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_CSTRING, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_CSTRING, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_CSTRING, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_CSTRING, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string? name;
		[HavokMember(EVersion.Havok_7_1_0_r1, 4, typeof(hkClass), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, typeof(hkClass), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 4, typeof(hkClass), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, typeof(hkClass), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkClass? @class;
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, typeof(hkClassEnum), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkClassEnum), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 8, typeof(hkClassEnum), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkClassEnum), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkClassEnum? @enum;
		[HavokMember(EVersion.Havok_7_1_0_r1, 12, null, typeof(hkClassMember.Type), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, typeof(hkClassMember.Type), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 12, null, typeof(hkClassMember.Type), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, typeof(hkClassMember.Type), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkClassMember.Type type;
		[HavokMember(EVersion.Havok_7_1_0_r1, 13, null, typeof(hkClassMember.Type), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 13, null, typeof(hkClassMember.Type), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 13, null, typeof(hkClassMember.Type), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 13, null, typeof(hkClassMember.Type), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkClassMember.Type subtype;
		[HavokMember(EVersion.Havok_7_1_0_r1, 14, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 14, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 14, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 14, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short cArraySize;
		[HavokMember(EVersion.Havok_7_1_0_r1, 16, null, typeof(hkClassMember.FlagValues), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_UINT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, typeof(hkClassMember.FlagValues), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_UINT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 16, null, typeof(hkClassMember.FlagValues), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_UINT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, typeof(hkClassMember.FlagValues), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_UINT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkClassMember.FlagValues flags;
		[HavokMember(EVersion.Havok_7_1_0_r1, 18, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 18, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 18, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 18, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort offset;
		[HavokMember(EVersion.Havok_7_1_0_r1, 20, typeof(hkCustomAttributes), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, typeof(hkCustomAttributes), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 20, typeof(hkCustomAttributes), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, typeof(hkCustomAttributes), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private hkCustomAttributes? attributes;
	}
}
