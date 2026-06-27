namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdDynamicTreeTreehkcdDynamicTreeDynamicStoragePtr : hkcdDynamicTreeDynamicStoragePtr
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint numLeaves;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint path;
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, null, null, Type.TYPE_ULONG, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, null, null, Type.TYPE_ULONG, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ulong root;
	}
}
