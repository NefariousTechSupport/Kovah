namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdStaticPvs
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkcdStaticTreeTreehkcdStaticTreeDynamicStorage6), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkcdStaticTreeTreehkcdStaticTreeDynamicStorage6? cells;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int bytesPerCells;
		[HavokMember(EVersion.hk_2014_1_0_r1, 52, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int cellsPerBlock;
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte[]? pvs;
		[HavokMember(EVersion.hk_2014_1_0_r1, 68, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort[]? map;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, typeof(hkcdStaticPvsBlockHeader), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkcdStaticPvsBlockHeader?[]? blocks;
	}
}
