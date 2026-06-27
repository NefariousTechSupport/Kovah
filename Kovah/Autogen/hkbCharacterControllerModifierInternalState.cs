namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCharacterControllerModifierInternalState : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 gravity;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool isInitialVelocityAdded;
		[HavokMember(EVersion.hk_2012_1_0_r1, 33, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 33, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool isTouchingGround;
	}
}
