namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpMalleableConstraintData : hkpConstraintData
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, typeof(hkpConstraintData), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpConstraintData? constraintData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, typeof(hkpBridgeAtoms), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpBridgeAtoms? atoms;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float strength;
	}
}
