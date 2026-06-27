namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpVehicleDefaultSuspension : hknpVehicleSuspension
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, typeof(hknpVehicleDefaultSuspensionWheelSpringSuspensionParameters), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpVehicleDefaultSuspensionWheelSpringSuspensionParameters?[]? wheelSpringParams;
	}
}
