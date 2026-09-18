namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	public partial class hkpMeshShape : hkpShapeCollection
	{
		public enum MeshShapeIndexStridingType : int
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
		public enum MeshShapeMaterialIndexStridingType : int
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
		[HavokMember(EVersion.Havok_7_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 scaling;
		[HavokMember(EVersion.Havok_7_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int numBitsForSubpartIndex;
		[HavokMember(EVersion.Havok_7_1_0_r1, 52, typeof(hkpMeshShapeSubpart), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpMeshShapeSubpart?[]? subparts;
		[HavokMember(EVersion.Havok_7_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort[]? weldingInfo;
		[HavokMember(EVersion.Havok_7_1_0_r1, 76, null, typeof(hkpWeldingUtility.WeldingType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpWeldingUtility.WeldingType weldingType;
		[HavokMember(EVersion.Havok_7_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float radius;
		[HavokMember(EVersion.Havok_7_1_0_r1, 84, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 3, hkClassMember.FlagValues.FLAGS_NONE)]
		private int pad;
	}
}
