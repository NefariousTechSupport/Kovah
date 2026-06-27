namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpSerializedTrack1nInfo
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkpAgent1nSector), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? sectors;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, typeof(hkpSerializedSubTrack1nInfo), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? subTracks;
	}
}
