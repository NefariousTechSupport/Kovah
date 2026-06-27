namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpPulleyConstraintData : hkpConstraintData
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, typeof(hkpPulleyConstraintDataAtoms), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.ALIGN_16)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hkpPulleyConstraintDataAtoms), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.ALIGN_16)]
		private hkpPulleyConstraintDataAtoms? atoms;
	}
}
