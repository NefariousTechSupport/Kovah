namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpSerializedAgentNnEntry : hkReferencedObject
	{
		public enum SerializedAgentType
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			INVALID_AGENT_TYPE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			BOX_BOX_AGENT3,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			CAPSULE_TRIANGLE_AGENT3,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			PRED_GSK_AGENT3,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			PRED_GSK_CYLINDER_AGENT3,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			CONVEX_LIST_AGENT3,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			LIST_AGENT3,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 7)]
			BV_TREE_AGENT3,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			COLLECTION_COLLECTION_AGENT3,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 9)]
			COLLECTION_AGENT3,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkpEntity), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpEntity? bodyA;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, typeof(hkpEntity), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpEntity? bodyB;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_ULONG, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ulong bodyAId;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, null, Type.TYPE_ULONG, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ulong bodyBId;
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool useEntityIds;
		[HavokMember(EVersion.hk_2012_1_0_r1, 25, null, typeof(hkpSerializedAgentNnEntry.SerializedAgentType), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkpSerializedAgentNnEntry.SerializedAgentType agentType;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, typeof(hkpSimpleContactConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpSimpleContactConstraintAtom? atom;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private byte[]? propertiesStream;
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, typeof(hkContactPoint), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkContactPoint?[]? contactPoints;
		[HavokMember(EVersion.hk_2012_1_0_r1, 104, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private byte[]? cpIdMgr;
		[HavokMember(EVersion.hk_2012_1_0_r1, 116, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 192, FlagValues.FLAGS_NONE)]
		private byte nnEntryData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 308, typeof(hkpSerializedTrack1nInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpSerializedTrack1nInfo? trackInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 332, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 4, FlagValues.FLAGS_NONE)]
		private byte endianCheckBuffer;
		[HavokMember(EVersion.hk_2012_1_0_r1, 336, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint version;
	}
}
