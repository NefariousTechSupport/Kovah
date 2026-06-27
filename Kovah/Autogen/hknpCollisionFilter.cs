namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpCollisionFilter : hkReferencedObject
	{
		public enum Type
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			TYPE_UNKNOWN,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			TYPE_CONSTRAINT,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			TYPE_GROUP,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			TYPE_PAIR,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			TYPE_USER,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, typeof(hknpCollisionFilter.Type), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpCollisionFilter.Type type;
	}
}
