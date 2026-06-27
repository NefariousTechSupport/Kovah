namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpCustomVVBroadPhaseConfig : hknpBroadPhaseConfig
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hknpBroadPhaseConfigLayer), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 6, FlagValues.FLAGS_NONE)]
		private hknpBroadPhaseConfigLayer? layers;
	}
}
