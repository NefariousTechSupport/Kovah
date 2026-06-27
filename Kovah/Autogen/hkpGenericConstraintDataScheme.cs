namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpGenericConstraintDataScheme
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkpGenericConstraintDataSchemeConstraintInfo), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private hkpGenericConstraintDataSchemeConstraintInfo? info;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VECTOR4, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4[]? data;
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int[]? commands;
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? modifiers;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, typeof(hkpConstraintMotor), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? motors;
	}
}
