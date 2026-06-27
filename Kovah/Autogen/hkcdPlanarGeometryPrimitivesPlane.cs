namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdPlanarGeometryPrimitivesPlane
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_INT64, Type.TYPE_VOID, 4, FlagValues.FLAGS_NONE)]
		private long iEqn;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_INT64, Type.TYPE_VOID, 4, FlagValues.SERIALIZE_IGNORED)]
		private long dEqn;
	}
}
