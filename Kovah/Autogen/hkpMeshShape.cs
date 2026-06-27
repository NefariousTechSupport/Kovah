namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	public partial class hkpMeshShape : hkpShapeCollection
	{
		public enum MeshShapeIndexStridingType
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			INDICES_INVALID,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			INDICES_INT16,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			INDICES_INT32,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 3)]
			INDICES_MAX_ID,
			
		}
		public enum MeshShapeMaterialIndexStridingType
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			MATERIAL_INDICES_INVALID,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			MATERIAL_INDICES_INT8,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			MATERIAL_INDICES_INT16,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 3)]
			MATERIAL_INDICES_MAX_ID,
			
		}
		[HavokMember(EVersion.Havok_7_1_0_r1, 32, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 scaling;
		[HavokMember(EVersion.Havok_7_1_0_r1, 48, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int numBitsForSubpartIndex;
		[HavokMember(EVersion.Havok_7_1_0_r1, 52, typeof(hkpMeshShapeSubpart), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpMeshShapeSubpart?[]? subparts;
		[HavokMember(EVersion.Havok_7_1_0_r1, 64, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private ushort[]? weldingInfo;
		[HavokMember(EVersion.Havok_7_1_0_r1, 76, null, typeof(hkpWeldingUtility.WeldingType), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hkpWeldingUtility.WeldingType weldingType;
		[HavokMember(EVersion.Havok_7_1_0_r1, 80, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float radius;
		[HavokMember(EVersion.Havok_7_1_0_r1, 84, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		private int pad;
	}
}
