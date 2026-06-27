namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCharacter : hkReferencedObject
	{
		public enum CapabilityTypes
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			FULL_POSE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			MIRRORING,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			DOCKING,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			HAND_IK,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			CHARACTER_CONTROL,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 32)]
			RAGDOLL,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 64)]
			FOOT_IK,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 128)]
			AI_CONTROL,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 7)]
			BASIC_CAPABILITIES,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 120)]
			PHYSICS_CAPABILITIES,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 127)]
			STANDARD_CAPABILITIES,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkbCharacter), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkbCharacter), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? nearbyCharacters;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short currentLod;
		[HavokMember(EVersion.hk_2012_1_0_r1, 22, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 26, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private short numTracksInLod;
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, null, null, Type.TYPE_ULONG, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, Type.TYPE_ULONG, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ulong userData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ generatorOutput;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? name;
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ ragdollDriver;
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ characterControllerDriver;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ footIkDriver;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 52, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ handIkDriver;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ dockingDriver;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, typeof(hkbCharacterSetup), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, typeof(hkbCharacterSetup), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbCharacterSetup? setup;
		[HavokMember(EVersion.hk_2012_1_0_r1, 60, typeof(hkbBehaviorGraph), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 68, typeof(hkbBehaviorGraph), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbBehaviorGraph? behaviorGraph;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, typeof(hkbProjectData), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 72, typeof(hkbProjectData), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbProjectData? projectData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 76, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ animationBindingSet;
		[HavokMember(EVersion.hk_2012_1_0_r1, 72, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ raycastInterface;
		[HavokMember(EVersion.hk_2012_1_0_r1, 76, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.NOT_OWNED|FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 84, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.NOT_OWNED|FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ world;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 88, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? boneAttachments;
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 100, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ eventQueue;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 104, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ characterLuaState;
		[HavokMember(EVersion.hk_2012_1_0_r1, 100, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 108, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ assetManager;
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ ragdollInterface;
		[HavokMember(EVersion.hk_2014_1_0_r1, 60, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ aiControlDriver;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ spatialQueryInterface;
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int capabilities;
		[HavokMember(EVersion.hk_2014_1_0_r1, 116, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int effectiveCapabilities;
		[HavokMember(EVersion.hk_2014_1_0_r1, 120, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool stateDirty;
	}
}
