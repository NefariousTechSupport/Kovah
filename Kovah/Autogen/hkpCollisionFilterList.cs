namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpCollisionFilterList : hkpCollisionFilter
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 48, typeof(hkpCollisionFilter), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkpCollisionFilter), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? collisionFilters;
	}
}
