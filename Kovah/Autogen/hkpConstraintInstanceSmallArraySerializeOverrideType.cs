namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	public partial class hkpConstraintInstanceSmallArraySerializeOverrideType
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 0, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 0, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 0, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ data;
		[HavokMember(EVersion.Havok_7_1_0_r1, 4, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 4, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 4, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort size;
		[HavokMember(EVersion.Havok_7_1_0_r1, 6, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 6, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 6, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 6, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort capacityAndFlags;
	}
}
