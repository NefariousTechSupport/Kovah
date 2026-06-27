namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbConstraintSetup
	{
		public enum Type
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			BALL_AND_SOCKET,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			RAGDOLL,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, typeof(hkbConstraintSetup.Type), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbConstraintSetup.Type type;
	}
}
