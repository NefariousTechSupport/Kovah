namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpPairCollisionFilter : hknpCollisionFilter
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, typeof(hknpPairCollisionFilterMapPairFilterKeyOverrideType), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private hknpPairCollisionFilterMapPairFilterKeyOverrideType? disabledPairs;
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, typeof(hknpCollisionFilter), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpCollisionFilter? childFilter;
	}
}
