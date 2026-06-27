namespace Kovah
{
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	public partial class hkpPairCollisionFilter : hkpCollisionFilter
	{
		[HavokMember(EVersion.hk_2011_2_0_r1, 48, typeof(hkpPairCollisionFilterMapPairFilterKeyOverrideType), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkpPairCollisionFilterMapPairFilterKeyOverrideType), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 48, typeof(hkpPairCollisionFilterMapPairFilterKeyOverrideType), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private hkpPairCollisionFilterMapPairFilterKeyOverrideType? disabledPairs;
		[HavokMember(EVersion.hk_2011_2_0_r1, 60, typeof(hkpCollisionFilter), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 60, typeof(hkpCollisionFilter), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 60, typeof(hkpCollisionFilter), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpCollisionFilter? childFilter;
	}
}
