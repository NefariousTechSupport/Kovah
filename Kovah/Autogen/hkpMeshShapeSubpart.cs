namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	public partial class hkpMeshShapeSubpart
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 0, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ vertexBase;
		[HavokMember(EVersion.Havok_7_1_0_r1, 4, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int vertexStriding;
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int numVertices;
		[HavokMember(EVersion.Havok_7_1_0_r1, 12, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ indexBase;
		[HavokMember(EVersion.Havok_7_1_0_r1, 16, null, typeof(hkpMeshShape.MeshShapeIndexStridingType), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkpMeshShape.MeshShapeIndexStridingType stridingType;
		[HavokMember(EVersion.Havok_7_1_0_r1, 17, null, typeof(hkpMeshShape.MeshShapeMaterialIndexStridingType), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkpMeshShape.MeshShapeMaterialIndexStridingType materialIndexStridingType;
		[HavokMember(EVersion.Havok_7_1_0_r1, 20, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int indexStriding;
		[HavokMember(EVersion.Havok_7_1_0_r1, 24, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int flipAlternateTriangles;
		[HavokMember(EVersion.Havok_7_1_0_r1, 28, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int numTriangles;
		[HavokMember(EVersion.Havok_7_1_0_r1, 32, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ materialIndexBase;
		[HavokMember(EVersion.Havok_7_1_0_r1, 36, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int materialIndexStriding;
		[HavokMember(EVersion.Havok_7_1_0_r1, 40, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ materialBase;
		[HavokMember(EVersion.Havok_7_1_0_r1, 44, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int materialStriding;
		[HavokMember(EVersion.Havok_7_1_0_r1, 48, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int numMaterials;
		[HavokMember(EVersion.Havok_7_1_0_r1, 52, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int triangleOffset;
	}
}
