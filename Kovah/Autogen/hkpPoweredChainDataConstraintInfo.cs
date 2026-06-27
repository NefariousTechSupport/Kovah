namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpPoweredChainDataConstraintInfo
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 pivotInA;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 pivotInB;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion aTc;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion bTc;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, typeof(hkpConstraintMotor), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 3, FlagValues.FLAGS_NONE)]
		private hkpConstraintMotor? motors;
		[HavokMember(EVersion.hk_2012_1_0_r1, 76, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool switchBodies;
	}
}
