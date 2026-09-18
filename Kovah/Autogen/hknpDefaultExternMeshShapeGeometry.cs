namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpDefaultExternMeshShapeGeometry : hknpExternMeshShapeGeometry
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hkGeometry), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.ALIGN_16)]
		private hkGeometry? geometry;
	}
}
