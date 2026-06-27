namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdPlanarGeometry : hkcdPlanarEntity
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, typeof(hkcdPlanarGeometryPlanesCollection), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkcdPlanarGeometryPlanesCollection? planes;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hkcdPlanarGeometryPolygonCollection), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkcdPlanarGeometryPolygonCollection? polys;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ vertices;
	}
}
