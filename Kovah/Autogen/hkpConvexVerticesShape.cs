namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpConvexVerticesShape : hkpConvexShape
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 aabbHalfExtents;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 aabbCenter;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, typeof(hkFourTransposedPoints), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkFourTransposedPoints?[]? rotatedVertices;
		[HavokMember(EVersion.hk_2012_1_0_r1, 76, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int numVertices;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool useSpuBuffer;
		[HavokMember(EVersion.hk_2012_1_0_r1, 84, null, null, Type.TYPE_ARRAY, Type.TYPE_VECTOR4, 0, FlagValues.FLAGS_NONE)]
		private Vector4[]? planeEquations;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, typeof(hkpConvexVerticesConnectivity), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpConvexVerticesConnectivity? connectivity;
	}
}
