namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpBodyQuality
	{
		public enum FlagsEnum
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			DROP_MANIFOLD_CACHE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			FORCE_GSK_EXECUTION,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			FORCE_GSK_SINGLE_POINT_MANIFOLD,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			ALLOW_INTERIOR_TRIANGLE_COLLISIONS,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			ENABLE_SILHOUETTE_MANIFOLDS,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 64)]
			USE_HIGHER_QUALITY_CONTACT_SOLVING,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 128)]
			ENABLE_NEIGHBOR_WELDING,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 256)]
			ENABLE_MOTION_WELDING,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 512)]
			ENABLE_TRIANGLE_WELDING,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 896)]
			ANY_WELDING,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1024)]
			ENABLE_CONTACT_CACHING,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2048)]
			REQUEST_LINEAR_ONLY_COLLISION_LOOK_AHEAD,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4096)]
			FORCE_LINEAR_ONLY_COLLISION_LOOK_AHEAD,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8192)]
			ENABLE_FRICTION_ESTIMATION,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 65536)]
			FIRST_NON_CACHABLE_FLAG,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 65536)]
			CLIP_ANGULAR_VELOCITY,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 131072)]
			USE_DISCRETE_AABB_EXPANSION,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 262144)]
			MERGE_FRICTION_JACOBIANS,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int priority;
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, typeof(hknpBodyQuality.FlagsEnum), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_UINT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpBodyQuality.FlagsEnum supportedFlags;
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, typeof(hknpBodyQuality.FlagsEnum), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_UINT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpBodyQuality.FlagsEnum requestedFlags;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float contactCachingRelativeMovementThreshold;
	}
}
