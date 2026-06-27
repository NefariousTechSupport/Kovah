namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpMalleableConstraintData : hkpWrappedConstraintData
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hknpBridgeConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hknpBridgeConstraintAtom? atom;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool wantsRuntime;
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float strength;
	}
}
