namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkClassEnum
	{
		public enum FlagValues
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			FLAGS_NONE,
			
		}
		[HavokMember(EVersion.Havok_7_1_0_r1, 0, null, null, Type.TYPE_CSTRING, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_CSTRING, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 0, null, null, Type.TYPE_CSTRING, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_CSTRING, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? name;
		[HavokMember(EVersion.Havok_7_1_0_r1, 4, typeof(hkClassEnumItem), null, Type.TYPE_SIMPLEARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, typeof(hkClassEnumItem), null, Type.TYPE_SIMPLEARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 4, typeof(hkClassEnumItem), null, Type.TYPE_SIMPLEARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, typeof(hkClassEnumItem), null, Type.TYPE_SIMPLEARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkClassEnumItem?[]? items;
		[HavokMember(EVersion.Havok_7_1_0_r1, 12, typeof(hkCustomAttributes), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, typeof(hkCustomAttributes), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 12, typeof(hkCustomAttributes), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, typeof(hkCustomAttributes), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.SERIALIZE_IGNORED)]
		private hkCustomAttributes? attributes;
		[HavokMember(EVersion.Havok_7_1_0_r1, 16, null, typeof(hkClassEnum.FlagValues), Type.TYPE_FLAGS, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, typeof(hkClassEnum.FlagValues), Type.TYPE_FLAGS, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 16, null, typeof(hkClassEnum.FlagValues), Type.TYPE_FLAGS, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, typeof(hkClassEnum.FlagValues), Type.TYPE_FLAGS, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private hkClassEnum.FlagValues flags;
	}
}
