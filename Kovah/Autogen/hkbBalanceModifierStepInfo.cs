namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbBalanceModifierStepInfo
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short boneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float fractionOfSolution;
	}
}
