namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdPlanarGeometry : hkcdPlanarEntity
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, typeof(hkcdPlanarGeometryPlanesCollection), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkcdPlanarGeometryPlanesCollection? planes;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hkcdPlanarGeometryPolygonCollection), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkcdPlanarGeometryPolygonCollection? polys;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ vertices;
	}
}
