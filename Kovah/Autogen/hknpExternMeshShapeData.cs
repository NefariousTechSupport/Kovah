namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpExternMeshShapeData : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hkcdStaticTreeDefaultTreeStorage6), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkcdStaticTreeDefaultTreeStorage6? aabbTree;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, typeof(hkcdSimdTree), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkcdSimdTree? simdTree;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ buildContext;
	}
}
