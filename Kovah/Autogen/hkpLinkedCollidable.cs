namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1, typeof(hkpCollidable))]
	[HavokClass(EVersion.hk_2011_2_0_r1, typeof(hkpCollidable))]
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkpCollidable))]
	[HavokClass(EVersion.hk_2013_1_0_r1, typeof(hkpCollidable))]
	public partial class hkpLinkedCollidable : hkpCollidable
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 80, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void* */[]? collisionEntries;
		public hkpLinkedCollidable()
		{
		}
	}
}
