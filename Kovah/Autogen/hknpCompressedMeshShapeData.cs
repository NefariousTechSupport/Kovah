namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpCompressedMeshShapeData : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hknpCompressedMeshShapeTree), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hknpCompressedMeshShapeTree? meshTree;
		[HavokMember(EVersion.hk_2014_1_0_r1, 160, typeof(hkcdSimdTree), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkcdSimdTree? simdTree;
	}
}
