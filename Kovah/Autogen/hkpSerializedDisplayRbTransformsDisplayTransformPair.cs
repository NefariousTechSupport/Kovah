namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpSerializedDisplayRbTransformsDisplayTransformPair
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkpRigidBody), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpRigidBody? rb;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_TRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Matrix4x4 /* transform */ localToDisplay;
	}
}
