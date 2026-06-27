namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpConvexPolytopeShape : hknpConvexShape
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, Type.TYPE_RELARRAY, Type.TYPE_VECTOR4, 0, FlagValues.FLAGS_NONE)]
		private object? /* relarray */ planes;
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, typeof(hknpConvexPolytopeShapeFace), null, Type.TYPE_RELARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private object? /* relarray */ faces;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_RELARRAY, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private object? /* relarray */ indices;
	}
}
