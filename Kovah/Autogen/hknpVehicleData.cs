namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpVehicleData : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 gravity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_INT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private sbyte numWheels;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_ROTATION, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Quaternion /* rotation */ chassisOrientation;
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float torqueRollFactor;
		[HavokMember(EVersion.hk_2014_1_0_r1, 100, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float torquePitchFactor;
		[HavokMember(EVersion.hk_2014_1_0_r1, 104, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float torqueYawFactor;
		[HavokMember(EVersion.hk_2014_1_0_r1, 108, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float extraTorqueFactor;
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float maxVelocityForPositionalFriction;
		[HavokMember(EVersion.hk_2014_1_0_r1, 116, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float chassisUnitInertiaYaw;
		[HavokMember(EVersion.hk_2014_1_0_r1, 120, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float chassisUnitInertiaRoll;
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float chassisUnitInertiaPitch;
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float frictionEqualizer;
		[HavokMember(EVersion.hk_2014_1_0_r1, 132, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float normalClippingAngleCos;
		[HavokMember(EVersion.hk_2014_1_0_r1, 136, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float maxFrictionSolverMassRatio;
		[HavokMember(EVersion.hk_2014_1_0_r1, 140, typeof(hknpVehicleDataWheelComponentParams), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpVehicleDataWheelComponentParams?[]? wheelParams;
		[HavokMember(EVersion.hk_2014_1_0_r1, 152, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private sbyte[]? numWheelsPerAxle;
		[HavokMember(EVersion.hk_2014_1_0_r1, 164, typeof(hkpVehicleFrictionDescription), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpVehicleFrictionDescription? frictionDescription;
		[HavokMember(EVersion.hk_2014_1_0_r1, 384, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 chassisFrictionInertiaInvDiag;
		[HavokMember(EVersion.hk_2014_1_0_r1, 400, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool alreadyInitialised;
	}
}
