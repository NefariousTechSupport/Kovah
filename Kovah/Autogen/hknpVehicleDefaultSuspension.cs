namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpVehicleDefaultSuspension : hknpVehicleSuspension
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, typeof(hknpVehicleDefaultSuspensionWheelSpringSuspensionParameters), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpVehicleDefaultSuspensionWheelSpringSuspensionParameters?[]? wheelSpringParams;
	}
}
