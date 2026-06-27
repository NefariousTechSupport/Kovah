namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpPoweredChainMapper : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkpPoweredChainMapperLinkInfo), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpPoweredChainMapperLinkInfo?[]? links;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, typeof(hkpPoweredChainMapperTarget), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpPoweredChainMapperTarget?[]? targets;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, typeof(hkpConstraintChainInstance), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? chains;
	}
}
