namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpGenericConstraintDataScheme
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkpGenericConstraintDataSchemeConstraintInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private hkpGenericConstraintDataSchemeConstraintInfo? info;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_ARRAY, Type.TYPE_VECTOR4, 0, FlagValues.FLAGS_NONE)]
		private Vector4[]? data;
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, Type.TYPE_ARRAY, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private int[]? commands;
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? modifiers;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, typeof(hkpConstraintMotor), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? motors;
	}
}
