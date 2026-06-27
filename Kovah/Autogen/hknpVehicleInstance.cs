namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpVehicleInstance : hknpUnaryAction
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ world;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, typeof(hknpVehicleData), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpVehicleData? data;
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, typeof(hknpVehicleDriverInput), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpVehicleDriverInput? driverInput;
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, typeof(hknpVehicleSteering), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpVehicleSteering? steering;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, typeof(hknpVehicleEngine), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpVehicleEngine? engine;
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, typeof(hknpVehicleTransmission), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpVehicleTransmission? transmission;
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, typeof(hknpVehicleBrake), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpVehicleBrake? brake;
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, typeof(hknpVehicleSuspension), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpVehicleSuspension? suspension;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, typeof(hknpVehicleAerodynamics), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpVehicleAerodynamics? aerodynamics;
		[HavokMember(EVersion.hk_2014_1_0_r1, 52, typeof(hknpVehicleWheelCollide), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpVehicleWheelCollide? wheelCollide;
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, typeof(hknpTyremarksInfo), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpTyremarksInfo? tyreMarks;
		[HavokMember(EVersion.hk_2014_1_0_r1, 60, typeof(hknpVehicleVelocityDamper), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpVehicleVelocityDamper? velocityDamper;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, typeof(hknpVehicleInstanceWheelInfo), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpVehicleInstanceWheelInfo?[]? wheelsInfo;
		[HavokMember(EVersion.hk_2014_1_0_r1, 76, typeof(hkpVehicleFrictionStatus), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpVehicleFrictionStatus? frictionStatus;
		[HavokMember(EVersion.hk_2014_1_0_r1, 148, typeof(hknpVehicleDriverInputStatus), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpVehicleDriverInputStatus? deviceStatus;
		[HavokMember(EVersion.hk_2014_1_0_r1, 152, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_BOOL, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool[]? isFixed;
		[HavokMember(EVersion.hk_2014_1_0_r1, 164, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float wheelsTimeSinceMaxPedalInput;
		[HavokMember(EVersion.hk_2014_1_0_r1, 168, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool tryingToReverse;
		[HavokMember(EVersion.hk_2014_1_0_r1, 172, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float torque;
		[HavokMember(EVersion.hk_2014_1_0_r1, 176, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float rpm;
		[HavokMember(EVersion.hk_2014_1_0_r1, 180, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float mainSteeringAngle;
		[HavokMember(EVersion.hk_2014_1_0_r1, 184, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float mainSteeringAngleAssumingNoReduction;
		[HavokMember(EVersion.hk_2014_1_0_r1, 188, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_REAL, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float[]? wheelsSteeringAngle;
		[HavokMember(EVersion.hk_2014_1_0_r1, 200, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool isReversing;
		[HavokMember(EVersion.hk_2014_1_0_r1, 201, null, null, hkClassMember.Type.TYPE_INT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private sbyte currentGear;
		[HavokMember(EVersion.hk_2014_1_0_r1, 202, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool delayed;
		[HavokMember(EVersion.hk_2014_1_0_r1, 204, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float clutchDelayCountdown;
	}
}
