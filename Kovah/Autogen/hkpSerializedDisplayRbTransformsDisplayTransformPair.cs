namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpSerializedDisplayRbTransformsDisplayTransformPair
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkpRigidBody), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpRigidBody? rb;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_TRANSFORM, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Matrix4x4 /* transform */ localToDisplay;
	}
}
