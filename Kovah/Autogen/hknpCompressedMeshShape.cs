namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpCompressedMeshShape : hknpCompositeShape
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 72, typeof(hknpCompressedMeshShapeData), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpCompressedMeshShapeData? data;
		[HavokMember(EVersion.hk_2014_1_0_r1, 76, typeof(hkBitField), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkBitField? quadIsFlat;
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, typeof(hkBitField), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkBitField? triangleIsInterior;
		[HavokMember(EVersion.hk_2014_1_0_r1, 108, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private int numTriangles;
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private int numConvexShapes;
	}
}
