namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbDemoConfig : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkbDemoConfigCharacterInfo), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? characterInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, typeof(hkbDemoConfigTerrainInfo), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbDemoConfigTerrainInfo?[]? terrainInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int[]? skinAttributeIndices;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 16, hkClassMember.FlagValues.FLAGS_NONE)]
		private int buttonPressToEventMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 108, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 16, hkClassMember.FlagValues.FLAGS_NONE)]
		private int buttonReleaseToEventMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 172, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int worldUpAxis;
		[HavokMember(EVersion.hk_2012_1_0_r1, 176, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int extraCharacterClones;
		[HavokMember(EVersion.hk_2012_1_0_r1, 180, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int numTracks;
		[HavokMember(EVersion.hk_2012_1_0_r1, 184, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float proxyHeight;
		[HavokMember(EVersion.hk_2012_1_0_r1, 188, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float proxyRadius;
		[HavokMember(EVersion.hk_2012_1_0_r1, 192, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float proxyOffset;
		[HavokMember(EVersion.hk_2012_1_0_r1, 196, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string? rootPath;
		[HavokMember(EVersion.hk_2012_1_0_r1, 200, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string? projectDataFilename;
		[HavokMember(EVersion.hk_2012_1_0_r1, 204, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool useAttachments;
		[HavokMember(EVersion.hk_2012_1_0_r1, 205, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool useProxy;
		[HavokMember(EVersion.hk_2012_1_0_r1, 206, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool useSkyBox;
		[HavokMember(EVersion.hk_2012_1_0_r1, 207, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool useTrackingCamera;
		[HavokMember(EVersion.hk_2012_1_0_r1, 208, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool accumulateMotion;
		[HavokMember(EVersion.hk_2012_1_0_r1, 209, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool testCloning;
		[HavokMember(EVersion.hk_2012_1_0_r1, 210, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool useSplineCompression;
		[HavokMember(EVersion.hk_2012_1_0_r1, 211, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool forceLoad;
		[HavokMember(EVersion.hk_2012_1_0_r1, 212, typeof(hkbDemoConfigStickVariableInfo), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbDemoConfigStickVariableInfo?[]? stickVariables;
		[HavokMember(EVersion.hk_2012_1_0_r1, 224, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 6, hkClassMember.FlagValues.FLAGS_NONE)]
		private int gamePadToRotateTerrainAboutItsAxisMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 248, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 2, hkClassMember.FlagValues.FLAGS_NONE)]
		private int gamePadToAddRemoveCharacterMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 256, typeof(hkpGroupFilter), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpGroupFilter? filter;
	}
}
