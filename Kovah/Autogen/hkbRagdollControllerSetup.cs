namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbRagdollControllerSetup
	{
		public enum Type : int
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			POWERED,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			RIGID_BODY,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, typeof(hkbRagdollControllerSetup.Type), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbRagdollControllerSetup.Type type;
	}
}
