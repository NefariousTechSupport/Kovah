namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpVehicleSuspension : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hknpVehicleSuspensionSuspensionWheelParameters), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpVehicleSuspensionSuspensionWheelParameters?[]? wheelParams;
	}
}
