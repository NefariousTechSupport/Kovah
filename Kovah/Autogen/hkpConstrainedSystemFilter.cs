namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1, typeof(hkpCollisionFilter))]
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkpCollisionFilter))]
	public partial class hkpConstrainedSystemFilter : hkpCollisionFilter
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 52, typeof(hkpCollisionFilter), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, typeof(hkpCollisionFilter), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpCollisionFilter? otherFilter;
		public hkpConstrainedSystemFilter()
		{
		}
	}
}
