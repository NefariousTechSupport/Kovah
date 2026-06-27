namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpCompressedHeightFieldShape : hknpHeightFieldShape
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 216, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private ushort[]? storage;
		[HavokMember(EVersion.hk_2014_1_0_r1, 228, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private ushort[]? shapeTags;
		[HavokMember(EVersion.hk_2014_1_0_r1, 240, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool triangleFlip;
		[HavokMember(EVersion.hk_2014_1_0_r1, 244, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float offset;
		[HavokMember(EVersion.hk_2014_1_0_r1, 248, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float scale;
	}
}
