namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, null)]
	[HavokClass(EVersion.hk_2014_1_0_r1, null)]
	public partial class hkbEventInfo
	{
		[Flags]
		public enum Flags : int
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			FLAG_SILENT = 1,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			FLAG_SYNC_POINT = 2,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, typeof(hkbEventInfo.Flags), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_UINT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, typeof(hkbEventInfo.Flags), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_UINT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbEventInfo.Flags flags;
		public hkbEventInfo()
		{
		}
	}
}
