namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdPlanarGeometryPrimitivesCollection28 : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_ARRAY, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private int[]? storage;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint primaryBitmap;
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 26, FlagValues.FLAGS_NONE)]
		private uint secondaryBitmaps;
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 832, FlagValues.FLAGS_NONE)]
		private uint freeBlocks;
	}
}
