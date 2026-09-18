namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpConvexVerticesShape : hkpConvexShape
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 aabbHalfExtents;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 aabbCenter;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, typeof(hkFourTransposedPoints), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkFourTransposedPoints?[]? rotatedVertices;
		[HavokMember(EVersion.hk_2012_1_0_r1, 76, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int numVertices;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private bool useSpuBuffer;
		[HavokMember(EVersion.hk_2012_1_0_r1, 84, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VECTOR4, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4[]? planeEquations;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, typeof(hkpConvexVerticesConnectivity), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpConvexVerticesConnectivity? connectivity;
	}
}
