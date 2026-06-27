namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	public partial class hkpSimpleMeshShape : hkpShapeCollection
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 24, null, null, Type.TYPE_ARRAY, Type.TYPE_VECTOR4, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 24, null, null, Type.TYPE_ARRAY, Type.TYPE_VECTOR4, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 24, null, null, Type.TYPE_ARRAY, Type.TYPE_VECTOR4, 0, FlagValues.FLAGS_NONE)]
		private Vector4[]? vertices;
		[HavokMember(EVersion.Havok_7_1_0_r1, 36, typeof(hkpSimpleMeshShapeTriangle), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 36, typeof(hkpSimpleMeshShapeTriangle), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 36, typeof(hkpSimpleMeshShapeTriangle), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpSimpleMeshShapeTriangle?[]? triangles;
		[HavokMember(EVersion.Havok_7_1_0_r1, 48, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 48, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 48, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private byte[]? materialIndices;
		[HavokMember(EVersion.Havok_7_1_0_r1, 60, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 60, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 60, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float radius;
		[HavokMember(EVersion.Havok_7_1_0_r1, 64, null, typeof(hkpWeldingUtility.WeldingType), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 64, null, typeof(hkpWeldingUtility.WeldingType), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 64, null, typeof(hkpWeldingUtility.WeldingType), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hkpWeldingUtility.WeldingType weldingType;
	}
}
