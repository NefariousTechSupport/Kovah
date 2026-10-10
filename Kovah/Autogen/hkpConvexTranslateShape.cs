namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkpConvexTransformShapeBase))]
	public partial class hkpConvexTranslateShape : hkpConvexTransformShapeBase
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 translation;
		public hkpConvexTranslateShape()
		{
		}
	}
}
