namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpVehicleDefaultBrake : hknpVehicleBrake
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hknpVehicleDefaultBrakeWheelBrakingProperties), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpVehicleDefaultBrakeWheelBrakingProperties?[]? wheelBrakingProperties;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float wheelsMinTimeToBlock;
	}
}
