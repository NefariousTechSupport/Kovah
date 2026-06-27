namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbAuxiliaryNodeInfo : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, typeof(hkbToolNodeType.NodeType), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, typeof(hkbToolNodeType.NodeType), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private hkbToolNodeType.NodeType type;
		[HavokMember(EVersion.hk_2012_1_0_r1, 10, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 10, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte depth;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? referenceBehaviorName;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		private string?[]? selfTransitionNames;
	}
}
