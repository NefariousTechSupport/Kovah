namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbEvaluateExpressionModifier : hkbModifier
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkbExpressionDataArray), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, typeof(hkbExpressionDataArray), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbExpressionDataArray? expressions;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 52, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ compiledExpressionSet;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? internalExpressionsData;
	}
}
