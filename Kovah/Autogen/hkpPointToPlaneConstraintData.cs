namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpPointToPlaneConstraintData : hkpConstraintData
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, typeof(hkpPointToPlaneConstraintDataAtoms), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.ALIGN_16)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hkpPointToPlaneConstraintDataAtoms), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.ALIGN_16)]
		private hkpPointToPlaneConstraintDataAtoms? atoms;
	}
}
