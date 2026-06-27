namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpMotion
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 centerOfMassAndMassFactor;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion orientation;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_HALF, Type.TYPE_VOID, 4, FlagValues.FLAGS_NONE)]
		private Half inverseInertia;
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint firstAttachedBodyId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private uint solverId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_HALF, Type.TYPE_VOID, 3, FlagValues.ALIGN_16)]
		private Half linearVelocityCage;
		[HavokMember(EVersion.hk_2014_1_0_r1, 54, null, null, Type.TYPE_HALF, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Half integrationFactor;
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort motionPropertiesId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 58, null, null, Type.TYPE_HALF, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Half maxLinearAccelerationDistancePerStep;
		[HavokMember(EVersion.hk_2014_1_0_r1, 60, null, null, Type.TYPE_HALF, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Half maxRotationToPreventTunneling;
		[HavokMember(EVersion.hk_2014_1_0_r1, 62, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte cellIndex;
		[HavokMember(EVersion.hk_2014_1_0_r1, 63, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte spaceSplitterWeight;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 linearVelocity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 angularVelocity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 previousStepLinearVelocity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 previousStepAngularVelocity;
	}
}
