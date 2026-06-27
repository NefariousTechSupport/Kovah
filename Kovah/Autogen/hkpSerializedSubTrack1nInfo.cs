namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpSerializedSubTrack1nInfo : hkpSerializedTrack1nInfo
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int sectorIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int offsetInSector;
	}
}
