namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCharacterControllerSetup
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkbRigidBodySetup), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbRigidBodySetup? rigidBodySetup;
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, typeof(hkReferencedObject), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkReferencedObject? controllerCinfo;
	}
}
