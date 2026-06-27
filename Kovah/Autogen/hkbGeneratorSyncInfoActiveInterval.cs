namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbGeneratorSyncInfoActiveInterval
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkbGeneratorSyncInfoSyncPoint), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkbGeneratorSyncInfoSyncPoint), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private hkbGeneratorSyncInfoSyncPoint? syncPoints;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float fraction;
	}
}
