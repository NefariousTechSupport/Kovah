namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpMultiRayShapeRay
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 start;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 end;
	}
}
