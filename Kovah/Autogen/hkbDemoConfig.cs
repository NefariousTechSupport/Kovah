namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbDemoConfig : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkbDemoConfigCharacterInfo), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? characterInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, typeof(hkbDemoConfigTerrainInfo), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbDemoConfigTerrainInfo?[]? terrainInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_ARRAY, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private int[]? skinAttributeIndices;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 16, FlagValues.FLAGS_NONE)]
		private int buttonPressToEventMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 108, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 16, FlagValues.FLAGS_NONE)]
		private int buttonReleaseToEventMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 172, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int worldUpAxis;
		[HavokMember(EVersion.hk_2012_1_0_r1, 176, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int extraCharacterClones;
		[HavokMember(EVersion.hk_2012_1_0_r1, 180, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int numTracks;
		[HavokMember(EVersion.hk_2012_1_0_r1, 184, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float proxyHeight;
		[HavokMember(EVersion.hk_2012_1_0_r1, 188, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float proxyRadius;
		[HavokMember(EVersion.hk_2012_1_0_r1, 192, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float proxyOffset;
		[HavokMember(EVersion.hk_2012_1_0_r1, 196, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? rootPath;
		[HavokMember(EVersion.hk_2012_1_0_r1, 200, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? projectDataFilename;
		[HavokMember(EVersion.hk_2012_1_0_r1, 204, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool useAttachments;
		[HavokMember(EVersion.hk_2012_1_0_r1, 205, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool useProxy;
		[HavokMember(EVersion.hk_2012_1_0_r1, 206, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool useSkyBox;
		[HavokMember(EVersion.hk_2012_1_0_r1, 207, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool useTrackingCamera;
		[HavokMember(EVersion.hk_2012_1_0_r1, 208, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool accumulateMotion;
		[HavokMember(EVersion.hk_2012_1_0_r1, 209, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool testCloning;
		[HavokMember(EVersion.hk_2012_1_0_r1, 210, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool useSplineCompression;
		[HavokMember(EVersion.hk_2012_1_0_r1, 211, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool forceLoad;
		[HavokMember(EVersion.hk_2012_1_0_r1, 212, typeof(hkbDemoConfigStickVariableInfo), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbDemoConfigStickVariableInfo?[]? stickVariables;
		[HavokMember(EVersion.hk_2012_1_0_r1, 224, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 6, FlagValues.FLAGS_NONE)]
		private int gamePadToRotateTerrainAboutItsAxisMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 248, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private int gamePadToAddRemoveCharacterMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 256, typeof(hkpGroupFilter), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpGroupFilter? filter;
	}
}
