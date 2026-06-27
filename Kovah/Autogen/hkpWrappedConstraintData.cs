namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpWrappedConstraintData : hkpConstraintData
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, typeof(hkpConstraintData), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpConstraintData? constraintData;
	}
}
