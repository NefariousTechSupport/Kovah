namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpMultiRayShape : hkpShape
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, typeof(hkpMultiRayShapeRay), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpMultiRayShapeRay?[]? rays;
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float rayPenetrationDistance;
	}
}
