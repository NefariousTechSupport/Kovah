namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	public partial class hkpWeldingUtility
	{
		public enum WeldingType
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			WELDING_TYPE_ANTICLOCKWISE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 4)]
			WELDING_TYPE_CLOCKWISE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 5)]
			WELDING_TYPE_TWO_SIDED,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 6)]
			WELDING_TYPE_NONE,
			
		}
		public enum SectorType
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			ACCEPT_0,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			SNAP_0,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			REJECT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			SNAP_1,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			ACCEPT_1,
			
		}
		public enum NumAngles
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 31)]
			NUM_ANGLES,
			
		}
	}
}
