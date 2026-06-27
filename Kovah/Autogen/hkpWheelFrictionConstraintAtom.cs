namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpWheelFrictionConstraintAtom : hkpConstraintAtom
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 2, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte isEnabled;
		[HavokMember(EVersion.hk_2014_1_0_r1, 3, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte forwardAxis;
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte sideAxis;
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float maxFrictionForce;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float torque;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float radius;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private float frictionImpulse;
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private float slipImpulse;
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, typeof(hkpWheelFrictionConstraintAtomAxle), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpWheelFrictionConstraintAtomAxle? axle;
	}
}
