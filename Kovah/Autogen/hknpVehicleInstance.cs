namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpVehicleInstance : hknpUnaryAction
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ world;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, typeof(hknpVehicleData), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpVehicleData? data;
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, typeof(hknpVehicleDriverInput), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpVehicleDriverInput? driverInput;
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, typeof(hknpVehicleSteering), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpVehicleSteering? steering;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, typeof(hknpVehicleEngine), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpVehicleEngine? engine;
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, typeof(hknpVehicleTransmission), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpVehicleTransmission? transmission;
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, typeof(hknpVehicleBrake), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpVehicleBrake? brake;
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, typeof(hknpVehicleSuspension), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpVehicleSuspension? suspension;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, typeof(hknpVehicleAerodynamics), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpVehicleAerodynamics? aerodynamics;
		[HavokMember(EVersion.hk_2014_1_0_r1, 52, typeof(hknpVehicleWheelCollide), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpVehicleWheelCollide? wheelCollide;
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, typeof(hknpTyremarksInfo), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpTyremarksInfo? tyreMarks;
		[HavokMember(EVersion.hk_2014_1_0_r1, 60, typeof(hknpVehicleVelocityDamper), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpVehicleVelocityDamper? velocityDamper;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, typeof(hknpVehicleInstanceWheelInfo), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpVehicleInstanceWheelInfo?[]? wheelsInfo;
		[HavokMember(EVersion.hk_2014_1_0_r1, 76, typeof(hkpVehicleFrictionStatus), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpVehicleFrictionStatus? frictionStatus;
		[HavokMember(EVersion.hk_2014_1_0_r1, 148, typeof(hknpVehicleDriverInputStatus), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpVehicleDriverInputStatus? deviceStatus;
		[HavokMember(EVersion.hk_2014_1_0_r1, 152, null, null, Type.TYPE_ARRAY, Type.TYPE_BOOL, 0, FlagValues.FLAGS_NONE)]
		private bool[]? isFixed;
		[HavokMember(EVersion.hk_2014_1_0_r1, 164, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float wheelsTimeSinceMaxPedalInput;
		[HavokMember(EVersion.hk_2014_1_0_r1, 168, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool tryingToReverse;
		[HavokMember(EVersion.hk_2014_1_0_r1, 172, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float torque;
		[HavokMember(EVersion.hk_2014_1_0_r1, 176, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float rpm;
		[HavokMember(EVersion.hk_2014_1_0_r1, 180, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float mainSteeringAngle;
		[HavokMember(EVersion.hk_2014_1_0_r1, 184, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float mainSteeringAngleAssumingNoReduction;
		[HavokMember(EVersion.hk_2014_1_0_r1, 188, null, null, Type.TYPE_ARRAY, Type.TYPE_REAL, 0, FlagValues.FLAGS_NONE)]
		private float[]? wheelsSteeringAngle;
		[HavokMember(EVersion.hk_2014_1_0_r1, 200, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool isReversing;
		[HavokMember(EVersion.hk_2014_1_0_r1, 201, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private sbyte currentGear;
		[HavokMember(EVersion.hk_2014_1_0_r1, 202, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool delayed;
		[HavokMember(EVersion.hk_2014_1_0_r1, 204, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float clutchDelayCountdown;
	}
}
