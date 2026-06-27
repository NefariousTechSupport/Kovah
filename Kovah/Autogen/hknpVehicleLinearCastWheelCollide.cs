namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpVehicleLinearCastWheelCollide : hknpVehicleWheelCollide
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hknpVehicleLinearCastWheelCollideWheelState), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpVehicleLinearCastWheelCollideWheelState?[]? wheelStates;
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float maxExtraPenetration;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float startPointTolerance;
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint chassisBody;
	}
}
