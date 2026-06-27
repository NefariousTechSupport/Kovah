namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdStaticMeshTreehkcdStaticMeshTreeCommonConfigunsignedintunsignedlonglong1121hknpCompressedMeshShapeTreeDataRun : hkcdStaticMeshTreeBase
	{
		public enum TriangleMaterial
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			TM_SET_FROM_TRIANGLE_DATA_TYPE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			TM_SET_FROM_PRIMITIVE_KEY,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private uint[]? packedVertices;
		[HavokMember(EVersion.hk_2014_1_0_r1, 108, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT64, 0, FlagValues.FLAGS_NONE)]
		private ulong[]? sharedVertices;
		[HavokMember(EVersion.hk_2014_1_0_r1, 120, typeof(hknpCompressedMeshShapeTreeDataRun), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpCompressedMeshShapeTreeDataRun?[]? primitiveDataRuns;
	}
}
