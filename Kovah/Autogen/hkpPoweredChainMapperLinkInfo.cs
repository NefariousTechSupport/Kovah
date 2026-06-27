namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpPoweredChainMapperLinkInfo
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int firstTargetIdx;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int numTargets;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkpConstraintInstance), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpConstraintInstance? limitConstraint;
	}
}
