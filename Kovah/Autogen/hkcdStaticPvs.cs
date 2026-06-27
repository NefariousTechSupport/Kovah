namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdStaticPvs
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkcdStaticTreeTreehkcdStaticTreeDynamicStorage6), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkcdStaticTreeTreehkcdStaticTreeDynamicStorage6? cells;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int bytesPerCells;
		[HavokMember(EVersion.hk_2014_1_0_r1, 52, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int cellsPerBlock;
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private byte[]? pvs;
		[HavokMember(EVersion.hk_2014_1_0_r1, 68, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private ushort[]? map;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, typeof(hkcdStaticPvsBlockHeader), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkcdStaticPvsBlockHeader?[]? blocks;
	}
}
