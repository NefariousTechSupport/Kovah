namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpVehicleSuspensionSuspensionWheelParameters
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 hardpointChassisSpace;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 directionChassisSpace;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float length;
	}
}
