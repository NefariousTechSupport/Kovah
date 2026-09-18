namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpPairCollisionFilter : hknpCollisionFilter
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, typeof(hknpPairCollisionFilterMapPairFilterKeyOverrideType), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private hknpPairCollisionFilterMapPairFilterKeyOverrideType? disabledPairs;
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, typeof(hknpCollisionFilter), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpCollisionFilter? childFilter;
	}
}
