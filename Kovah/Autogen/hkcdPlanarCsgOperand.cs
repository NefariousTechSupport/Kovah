namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdPlanarCsgOperand : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkcdPlanarGeometry), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkcdPlanarGeometry? geometry;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, typeof(hkcdPlanarGeometry), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkcdPlanarGeometry? danglingGeometry;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hkcdPlanarSolid), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkcdPlanarSolid? solid;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, typeof(hkcdPlanarCsgOperandGeomSource), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkcdPlanarCsgOperandGeomSource?[]? geomSources;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ regions;
	}
}
