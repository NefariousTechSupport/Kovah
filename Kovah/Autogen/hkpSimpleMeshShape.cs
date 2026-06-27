namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	public partial class hkpSimpleMeshShape : hkpShapeCollection
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 24, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VECTOR4, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 24, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VECTOR4, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 24, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VECTOR4, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4[]? vertices;
		[HavokMember(EVersion.Havok_7_1_0_r1, 36, typeof(hkpSimpleMeshShapeTriangle), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 36, typeof(hkpSimpleMeshShapeTriangle), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 36, typeof(hkpSimpleMeshShapeTriangle), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpSimpleMeshShapeTriangle?[]? triangles;
		[HavokMember(EVersion.Havok_7_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 48, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte[]? materialIndices;
		[HavokMember(EVersion.Havok_7_1_0_r1, 60, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 60, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 60, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float radius;
		[HavokMember(EVersion.Havok_7_1_0_r1, 64, null, typeof(hkpWeldingUtility.WeldingType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 64, null, typeof(hkpWeldingUtility.WeldingType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 64, null, typeof(hkpWeldingUtility.WeldingType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpWeldingUtility.WeldingType weldingType;
	}
}
