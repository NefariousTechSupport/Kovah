namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdPlanarCsgOperand : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkcdPlanarGeometry), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkcdPlanarGeometry? geometry;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, typeof(hkcdPlanarGeometry), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkcdPlanarGeometry? danglingGeometry;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hkcdPlanarSolid), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkcdPlanarSolid? solid;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, typeof(hkcdPlanarCsgOperandGeomSource), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkcdPlanarCsgOperandGeomSource?[]? geomSources;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ regions;
	}
}
