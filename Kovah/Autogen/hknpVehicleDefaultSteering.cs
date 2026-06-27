namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpVehicleDefaultSteering : hknpVehicleSteering
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float maxSteeringAngle;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float maxSpeedFullSteeringAngle;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_ARRAY, Type.TYPE_BOOL, 0, FlagValues.FLAGS_NONE)]
		private bool[]? doesWheelSteer;
	}
}
