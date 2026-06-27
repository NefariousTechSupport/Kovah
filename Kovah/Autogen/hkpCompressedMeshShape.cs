namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpCompressedMeshShape : hkpShapeCollection
	{
		public enum MaterialType
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			MATERIAL_NONE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			MATERIAL_SINGLE_VALUE_PER_CHUNK,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			MATERIAL_ONE_BYTE_PER_TRIANGLE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			MATERIAL_TWO_BYTES_PER_TRIANGLE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			MATERIAL_FOUR_BYTES_PER_TRIANGLE,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int bitsPerIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int bitsPerWIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int wIndexMask;
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int indexMask;
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float radius;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, typeof(hkpWeldingUtility.WeldingType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpWeldingUtility.WeldingType weldingType;
		[HavokMember(EVersion.hk_2012_1_0_r1, 45, null, typeof(hkpCompressedMeshShape.MaterialType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpCompressedMeshShape.MaterialType materialType;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint[]? materials;
		[HavokMember(EVersion.hk_2012_1_0_r1, 60, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort[]? materials16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 72, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte[]? materials8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 84, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_QSTRANSFORM, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Matrix3x4[]? transforms;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VECTOR4, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4[]? bigVertices;
		[HavokMember(EVersion.hk_2012_1_0_r1, 108, typeof(hkpCompressedMeshShapeBigTriangle), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpCompressedMeshShapeBigTriangle?[]? bigTriangles;
		[HavokMember(EVersion.hk_2012_1_0_r1, 120, typeof(hkpCompressedMeshShapeChunk), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpCompressedMeshShapeChunk?[]? chunks;
		[HavokMember(EVersion.hk_2012_1_0_r1, 132, typeof(hkpCompressedMeshShapeConvexPiece), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpCompressedMeshShapeConvexPiece?[]? convexPieces;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float error;
		[HavokMember(EVersion.hk_2012_1_0_r1, 160, typeof(hkAabb), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkAabb? bounds;
		[HavokMember(EVersion.hk_2012_1_0_r1, 192, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint defaultCollisionFilterInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 196, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ meshMaterials;
		[HavokMember(EVersion.hk_2012_1_0_r1, 200, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort materialStriding;
		[HavokMember(EVersion.hk_2012_1_0_r1, 202, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort numMaterials;
		[HavokMember(EVersion.hk_2012_1_0_r1, 204, typeof(hkpNamedMeshMaterial), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpNamedMeshMaterial?[]? namedMaterials;
	}
}
