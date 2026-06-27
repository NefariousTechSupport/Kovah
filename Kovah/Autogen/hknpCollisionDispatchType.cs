namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpCollisionDispatchType
	{
		public enum Enum
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			NONE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			CONVEX,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			COMPOSITE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			DISTANCE_FIELD,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			USER,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			NUM_TYPES,
			
		}
	}
}
