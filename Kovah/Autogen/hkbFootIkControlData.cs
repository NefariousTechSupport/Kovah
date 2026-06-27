namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbFootIkControlData
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkbFootIkGains), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.ALIGN_16)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkbFootIkGains), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.ALIGN_16)]
		private hkbFootIkGains? gains;
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 8, FlagValues.FLAGS_NONE)]
		private float enabled;
	}
}
