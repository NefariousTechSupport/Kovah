namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbScriptCondition : hkbCondition
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? conditionScript;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private int refCondition;
	}
}
