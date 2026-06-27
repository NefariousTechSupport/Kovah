namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbLinkedSymbolInfo : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRINGPTR, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRINGPTR, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string?[]? eventNames;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRINGPTR, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRINGPTR, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string?[]? variableNames;
	}
}
