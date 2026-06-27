namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpVehicleInstanceWheelInfo
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkContactPoint), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkContactPoint? contactPoint;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float contactFriction;
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private uint contactBodyId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint contactShapeKey;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 hardPointWs;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 rayEndPointWs;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float currentSuspensionLength;
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 suspensionDirectionWs;
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 spinAxisChassisSpace;
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 spinAxisWs;
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion steeringOrientationChassisSpace;
		[HavokMember(EVersion.hk_2014_1_0_r1, 160, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float spinVelocity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 164, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float noSlipIdealSpinVelocity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 168, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float spinAngle;
		[HavokMember(EVersion.hk_2014_1_0_r1, 172, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float skidEnergyDensity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 176, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float sideForce;
		[HavokMember(EVersion.hk_2014_1_0_r1, 180, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float forwardSlipVelocity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 184, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float sideSlipVelocity;
	}
}
