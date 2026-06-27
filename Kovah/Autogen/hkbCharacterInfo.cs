namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCharacterInfo : hkReferencedObject
	{
		public enum Event
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			REMOVED_FROM_WORLD,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			SHOWN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			HIDDEN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			ACTIVATED,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			DEACTIVATED,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_UINT64, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_UINT64, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ulong characterId;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, typeof(hkbCharacterInfo.Event), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, typeof(hkbCharacterInfo.Event), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCharacterInfo.Event @event;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int padding;
	}
}
