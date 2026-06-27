namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpSurfaceVelocity : hkReferencedObject
	{
		public enum Space : int
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			USE_LOCAL_SPACE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			USE_WORLD_SPACE,
			
		}
	}
}
