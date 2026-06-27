namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbNode : hkbBindable
	{
		public enum GetChildrenFlagBits
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			FLAG_ACTIVE_ONLY,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			FLAG_GENERATORS_ONLY,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			FLAG_IGNORE_REFERENCED_BEHAVIORS,
			
		}
		public enum CloneState
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			CLONE_STATE_DEFAULT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			CLONE_STATE_TEMPLATE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			CLONE_STATE_CLONE,
			
		}
		public enum TemplateOrClone
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			NODE_IS_TEMPLATE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			NODE_IS_CLONE,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, Type.TYPE_ULONG, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, Type.TYPE_ULONG, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ulong userData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? name;
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private ushort id;
		[HavokMember(EVersion.hk_2012_1_0_r1, 38, null, null, Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 38, null, null, Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.SERIALIZE_IGNORED)]
		private sbyte cloneState;
		[HavokMember(EVersion.hk_2012_1_0_r1, 39, null, null, Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 39, null, null, Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.SERIALIZE_IGNORED)]
		private byte type;
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ nodeInfo;
	}
}
