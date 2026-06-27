namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpConstrainedSystemFilter : hkpCollisionFilter
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 52, typeof(hkpCollisionFilter), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, typeof(hkpCollisionFilter), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpCollisionFilter? otherFilter;
	}
}
