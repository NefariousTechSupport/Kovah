namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkcdStaticMeshTreehkcdStaticMeshTreeCommonConfigunsignedintunsignedlonglong1121hkpBvCompressedMeshShapeTreeDataRun : hkcdStaticMeshTreeBase
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private uint[]? packedVertices;
		[HavokMember(EVersion.hk_2012_1_0_r1, 108, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT64, 0, FlagValues.FLAGS_NONE)]
		private ulong[]? sharedVertices;
		[HavokMember(EVersion.hk_2012_1_0_r1, 120, typeof(hkpBvCompressedMeshShapeTreeDataRun), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpBvCompressedMeshShapeTreeDataRun?[]? primitiveDataRuns;
	}
}
