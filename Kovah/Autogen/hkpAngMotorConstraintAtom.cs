namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpAngMotorConstraintAtom : hkpConstraintAtom
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 2, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 2, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool isEnabled;
		[HavokMember(EVersion.hk_2012_1_0_r1, 3, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 3, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte motorAxis;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private short initializedOffset;
		[HavokMember(EVersion.hk_2012_1_0_r1, 6, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 6, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private short previousTargetAngleOffset;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private short correspondingAngLimitSolverResultOffset;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float targetAngle;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, typeof(hkpConstraintMotor), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hkpConstraintMotor), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpConstraintMotor? motor;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 12, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 12, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private byte padding;
	}
}
