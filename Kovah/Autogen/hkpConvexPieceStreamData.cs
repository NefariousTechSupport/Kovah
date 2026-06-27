namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpConvexPieceStreamData : hkReferencedObject
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private uint[]? convexPieceStream;
		[HavokMember(EVersion.Havok_7_1_0_r1, 20, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private uint[]? convexPieceOffsets;
		[HavokMember(EVersion.Havok_7_1_0_r1, 32, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private uint[]? convexPieceSingleTriangles;
	}
}
