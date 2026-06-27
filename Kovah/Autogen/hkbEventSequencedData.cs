namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbEventSequencedData : hkbSequencedData
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkbEventSequencedDataSequencedEvent), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkbEventSequencedDataSequencedEvent), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbEventSequencedDataSequencedEvent?[]? events;
	}
}
