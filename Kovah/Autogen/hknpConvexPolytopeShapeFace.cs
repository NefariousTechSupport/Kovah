namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpConvexPolytopeShapeFace
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort firstIndex;
		[HavokMember(EVersion.hk_2014_1_0_r1, 2, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte numIndices;
		[HavokMember(EVersion.hk_2014_1_0_r1, 3, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte minHalfAngle;
	}
}
