namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdStaticAabbTree : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool shouldDeleteTree;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, typeof(hkcdStaticTreeDefaultTreeStorage6), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkcdStaticTreeDefaultTreeStorage6? treePtr;
	}
}
