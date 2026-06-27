namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpMinMaxQuadTree
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hknpMinMaxQuadTreeMinMaxLevel), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpMinMaxQuadTreeMinMaxLevel?[]? coarseTreeData;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 offset;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float multiplier;
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float invMultiplier;
	}
}
