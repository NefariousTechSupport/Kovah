namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpConvexTransformShape : hkpConvexTransformShapeBase
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_QSTRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Matrix3x4 transform;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 extraScale;
	}
}
