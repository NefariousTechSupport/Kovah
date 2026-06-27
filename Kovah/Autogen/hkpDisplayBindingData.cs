namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpDisplayBindingData : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkpDisplayBindingDataRigidBody), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? rigidBodyBindings;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, typeof(hkpDisplayBindingDataPhysicsSystem), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? physicsSystemBindings;
	}
}
