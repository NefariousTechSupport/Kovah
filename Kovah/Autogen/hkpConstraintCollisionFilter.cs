namespace Kovah
{
	[HavokClass(EVersion.hk_2011_2_0_r1, typeof(hkpPairCollisionFilter))]
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkpPairCollisionFilter))]
	[HavokClass(EVersion.hk_2013_1_0_r1, typeof(hkpPairCollisionFilter))]
	public partial class hkpConstraintCollisionFilter : hkpPairCollisionFilter
	{
		public hkpConstraintCollisionFilter()
		{
		}
	}
}
