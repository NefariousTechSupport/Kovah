namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbBehaviorGraph : hkbGenerator
	{
		public enum VariableMode
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			VARIABLE_MODE_DISCARD_WHEN_INACTIVE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			VARIABLE_MODE_MAINTAIN_VALUES_WHEN_INACTIVE,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, null, typeof(hkbBehaviorGraph.VariableMode), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, null, typeof(hkbBehaviorGraph.VariableMode), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbBehaviorGraph.VariableMode variableMode;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? uniqueIdPool;
		[HavokMember(EVersion.hk_2012_1_0_r1, 108, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 108, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ idToStateMachineTemplateMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? mirroredExternalIdMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 124, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ pseudoRandomGenerator;
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, typeof(hkbGenerator), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, typeof(hkbGenerator), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbGenerator? rootGenerator;
		[HavokMember(EVersion.hk_2012_1_0_r1, 132, typeof(hkbBehaviorGraphData), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 132, typeof(hkbBehaviorGraphData), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbBehaviorGraphData? data;
		[HavokMember(EVersion.hk_2012_1_0_r1, 136, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 136, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ template;
		[HavokMember(EVersion.hk_2012_1_0_r1, 140, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 140, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ rootGeneratorClone;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ activeNodes;
		[HavokMember(EVersion.hk_2012_1_0_r1, 148, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 148, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ globalTransitionData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 152, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 152, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ eventIdMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 156, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 156, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ attributeIdMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 160, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 160, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ variableIdMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 164, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 164, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ characterPropertyIdMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 168, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 168, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ variableValueSet;
		[HavokMember(EVersion.hk_2012_1_0_r1, 172, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 172, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ nodeTemplateToCloneMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 176, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 176, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ stateListenerTemplateToCloneMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 180, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 180, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? recentlyCreatedClones;
		[HavokMember(EVersion.hk_2012_1_0_r1, 192, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 192, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ nodePartitionInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 196, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 196, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private int numIntermediateOutputs;
		[HavokMember(EVersion.hk_2012_1_0_r1, 200, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 200, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? intermediateOutputSizes;
		[HavokMember(EVersion.hk_2012_1_0_r1, 212, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 212, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? jobs;
		[HavokMember(EVersion.hk_2012_1_0_r1, 224, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 224, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? allPartitionMemory;
		[HavokMember(EVersion.hk_2012_1_0_r1, 236, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 236, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? internalToRootVariableIdMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 248, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 248, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? internalToCharacterCharacterPropertyIdMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 260, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 260, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? internalToRootAttributeIdMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 272, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 272, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private ushort nextUniqueId;
		[HavokMember(EVersion.hk_2012_1_0_r1, 274, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 274, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool isActive;
		[HavokMember(EVersion.hk_2012_1_0_r1, 275, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 275, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool isLinked;
		[HavokMember(EVersion.hk_2012_1_0_r1, 276, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 276, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool updateActiveNodes;
		[HavokMember(EVersion.hk_2012_1_0_r1, 277, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 277, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool updateActiveNodesForEnable;
		[HavokMember(EVersion.hk_2012_1_0_r1, 278, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 278, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool checkNodeValidity;
		[HavokMember(EVersion.hk_2012_1_0_r1, 279, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 279, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool stateOrTransitionChanged;
	}
}
