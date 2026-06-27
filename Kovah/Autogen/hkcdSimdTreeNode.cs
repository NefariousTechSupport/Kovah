namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdSimdTreeNode : hkcdFourAabb
	{
		public enum Flags : int
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			HAS_INTERNALS,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			HAS_LEAVES,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			HAS_NULLS,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint data;
	}
}
