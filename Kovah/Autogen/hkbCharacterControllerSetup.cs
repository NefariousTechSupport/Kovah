namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCharacterControllerSetup
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkbRigidBodySetup), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbRigidBodySetup? rigidBodySetup;
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, typeof(hkReferencedObject), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkReferencedObject? controllerCinfo;
	}
}
