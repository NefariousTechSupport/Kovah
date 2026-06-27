namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCompiledExpressionSet : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkbCompiledExpressionSetToken), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkbCompiledExpressionSetToken), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbCompiledExpressionSetToken?[]? rpn;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, null, Type.TYPE_ARRAY, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, Type.TYPE_ARRAY, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private int[]? expressionToRpnIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private sbyte numExpressions;
	}
}
