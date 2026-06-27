namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpVehicleFrictionDescriptionAxisDescription
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 16, FlagValues.FLAGS_NONE)]
		private float frictionCircleYtab;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float xStep;
		[HavokMember(EVersion.hk_2014_1_0_r1, 68, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float xStart;
		[HavokMember(EVersion.hk_2014_1_0_r1, 72, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float wheelSurfaceInertia;
		[HavokMember(EVersion.hk_2014_1_0_r1, 76, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float wheelSurfaceInertiaInv;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float wheelChassisMassRatio;
		[HavokMember(EVersion.hk_2014_1_0_r1, 84, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float wheelRadius;
		[HavokMember(EVersion.hk_2014_1_0_r1, 88, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float wheelRadiusInv;
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float wheelDownForceFactor;
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float wheelDownForceSumFactor;
	}
}
