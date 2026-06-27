namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	public partial class hkpMoppBvTreeShape : hkMoppBvTreeShapeBase
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 48, typeof(hkpSingleShapeContainer), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 48, typeof(hkpSingleShapeContainer), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkpSingleShapeContainer), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 48, typeof(hkpSingleShapeContainer), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpSingleShapeContainer? child;
		[HavokMember(EVersion.Havok_7_1_0_r1, 56, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 56, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 56, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private int childSize;
	}
}
