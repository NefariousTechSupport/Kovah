namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpVehicleDriverInputAnalogStatus : hknpVehicleDriverInputStatus
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float positionX;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float positionY;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool handbrakeButtonPressed;
		[HavokMember(EVersion.hk_2014_1_0_r1, 17, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool reverseButtonPressed;
	}
}
