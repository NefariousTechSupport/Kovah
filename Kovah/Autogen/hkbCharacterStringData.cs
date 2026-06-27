namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCharacterStringData : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkbCharacterStringDataFileNameMeshNamePair), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkbCharacterStringDataFileNameMeshNamePair), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbCharacterStringDataFileNameMeshNamePair?[]? skinNames;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, typeof(hkbCharacterStringDataFileNameMeshNamePair), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, typeof(hkbCharacterStringDataFileNameMeshNamePair), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbCharacterStringDataFileNameMeshNamePair?[]? boneAttachmentNames;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, typeof(hkbAssetBundleStringData), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, typeof(hkbAssetBundleStringData), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbAssetBundleStringData?[]? animationBundleNameData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, typeof(hkbAssetBundleStringData), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, typeof(hkbAssetBundleStringData), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbAssetBundleStringData?[]? animationBundleFilenameData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		private string?[]? characterPropertyNames;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 68, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		private string?[]? retargetingSkeletonMapperFilenames;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		private string?[]? lodNames;
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		private string?[]? mirroredSyncPointSubstringsA;
		[HavokMember(EVersion.hk_2012_1_0_r1, 104, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 104, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		private string?[]? mirroredSyncPointSubstringsB;
		[HavokMember(EVersion.hk_2012_1_0_r1, 116, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 116, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? name;
		[HavokMember(EVersion.hk_2012_1_0_r1, 120, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 120, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? rigName;
		[HavokMember(EVersion.hk_2012_1_0_r1, 124, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? ragdollName;
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? behaviorFilename;
		[HavokMember(EVersion.hk_2012_1_0_r1, 132, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 132, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? luaScriptOnCharacterActivated;
		[HavokMember(EVersion.hk_2012_1_0_r1, 136, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 136, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? luaScriptOnCharacterDeactivated;
		[HavokMember(EVersion.hk_2012_1_0_r1, 140, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 140, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		private string?[]? luaFiles;
	}
}
