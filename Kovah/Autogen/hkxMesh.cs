namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkxMesh : hkReferencedObject
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, typeof(hkxMeshSection), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 8, typeof(hkxMeshSection), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkxMeshSection), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 8, typeof(hkxMeshSection), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkxMeshSection), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? sections;
		[HavokMember(EVersion.Havok_7_1_0_r1, 20, typeof(hkxMeshUserChannelInfo), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 20, typeof(hkxMeshUserChannelInfo), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, typeof(hkxMeshUserChannelInfo), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 20, typeof(hkxMeshUserChannelInfo), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, typeof(hkxMeshUserChannelInfo), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? userChannelInfos;
	}
}
