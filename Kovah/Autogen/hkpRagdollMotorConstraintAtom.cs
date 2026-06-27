namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpRagdollMotorConstraintAtom : hkpConstraintAtom
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 2, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 2, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool isEnabled;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private short initializedOffset;
		[HavokMember(EVersion.hk_2012_1_0_r1, 6, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 6, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private short previousTargetAnglesOffset;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_MATRIX3, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_MATRIX3, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Matrix3x4 target_bRca;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, typeof(hkpConstraintMotor), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, typeof(hkpConstraintMotor), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 3, FlagValues.FLAGS_NONE)]
		private hkpConstraintMotor? motors;
	}
}
