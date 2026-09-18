namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdSimdTree : hkBaseObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, typeof(hkcdSimdTreeNode), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkcdSimdTreeNode?[]? nodes;
	}
}
