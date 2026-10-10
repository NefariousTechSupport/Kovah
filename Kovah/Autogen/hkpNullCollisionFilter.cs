namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1, typeof(hkpCollisionFilter))]
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkpCollisionFilter))]
	public partial class hkpNullCollisionFilter : hkpCollisionFilter
	{
		public hkpNullCollisionFilter()
		{
		}
	}
}
