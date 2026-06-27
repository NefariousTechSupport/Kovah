namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpDefaultBroadPhaseConfig : hknpBroadPhaseConfig
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hknpBroadPhaseConfigLayer), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpBroadPhaseConfigLayer? layers;
	}
}
