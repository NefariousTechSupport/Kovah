namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbEventRangeData
	{
		public enum EventRangeMode
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			EVENT_MODE_SEND_ON_ENTER_RANGE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			EVENT_MODE_SEND_WHEN_IN_RANGE,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float upperBound;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, typeof(hkbEventProperty), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, typeof(hkbEventProperty), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbEventProperty? @event;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, typeof(hkbEventRangeData.EventRangeMode), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, typeof(hkbEventRangeData.EventRangeMode), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbEventRangeData.EventRangeMode eventMode;
	}
}
