namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	public partial class hkpCollisionFilter : hkReferencedObject
	{
		public enum hkpFilterType
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			HK_FILTER_UNKNOWN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			HK_FILTER_NULL,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			HK_FILTER_GROUP,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 3)]
			HK_FILTER_LIST,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 4)]
			HK_FILTER_CUSTOM,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 5)]
			HK_FILTER_PAIR,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 6)]
			HK_FILTER_CONSTRAINT,
			
		}
		[HavokMember(EVersion.Havok_7_1_0_r1, 24, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 24, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 24, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private uint prepad;
		[HavokMember(EVersion.Havok_7_1_0_r1, 32, null, typeof(hkpCollisionFilter.hkpFilterType), Type.TYPE_ENUM, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 32, null, typeof(hkpCollisionFilter.hkpFilterType), Type.TYPE_ENUM, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, typeof(hkpCollisionFilter.hkpFilterType), Type.TYPE_ENUM, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 32, null, typeof(hkpCollisionFilter.hkpFilterType), Type.TYPE_ENUM, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private hkpCollisionFilter.hkpFilterType type;
		[HavokMember(EVersion.Havok_7_1_0_r1, 36, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 36, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 36, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		private uint postpad;
	}
}
