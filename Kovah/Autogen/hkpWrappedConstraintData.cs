namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpWrappedConstraintData : hkpConstraintData
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, typeof(hkpConstraintData), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpConstraintData? constraintData;
	}
}
