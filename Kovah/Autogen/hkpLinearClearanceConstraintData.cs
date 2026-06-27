namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpLinearClearanceConstraintData : hkpConstraintData
	{
		public enum Type
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			PRISMATIC,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			HINGE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			BALL_SOCKET,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hkpLinearClearanceConstraintDataAtoms), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.ALIGN_16)]
		private hkpLinearClearanceConstraintDataAtoms? atoms;
	}
}
