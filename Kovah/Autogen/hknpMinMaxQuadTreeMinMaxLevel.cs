namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpMinMaxQuadTreeMinMaxLevel
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private uint[]? minMaxData;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort xRes;
		[HavokMember(EVersion.hk_2014_1_0_r1, 14, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort zRes;
	}
}
