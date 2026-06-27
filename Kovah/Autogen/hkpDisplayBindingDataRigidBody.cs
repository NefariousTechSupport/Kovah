namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpDisplayBindingDataRigidBody : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkpRigidBody), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpRigidBody? rigidBody;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, typeof(hkReferencedObject), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkReferencedObject? displayObjectPtr;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_MATRIX4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Matrix4x4 rigidBodyFromDisplayObjectTransform;
	}
}
