namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpVehicleDefaultBrake : hknpVehicleBrake
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hknpVehicleDefaultBrakeWheelBrakingProperties), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpVehicleDefaultBrakeWheelBrakingProperties?[]? wheelBrakingProperties;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float wheelsMinTimeToBlock;
	}
}
