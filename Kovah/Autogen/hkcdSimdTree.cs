namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdSimdTree : hkBaseObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, typeof(hkcdSimdTreeNode), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkcdSimdTreeNode?[]? nodes;
	}
}
