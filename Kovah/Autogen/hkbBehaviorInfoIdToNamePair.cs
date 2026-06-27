namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbBehaviorInfoIdToNamePair
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? behaviorName;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? nodeName;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, typeof(hkbToolNodeType.NodeType), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, typeof(hkbToolNodeType.NodeType), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private hkbToolNodeType.NodeType toolType;
		[HavokMember(EVersion.hk_2012_1_0_r1, 10, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 10, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort id;
	}
}
