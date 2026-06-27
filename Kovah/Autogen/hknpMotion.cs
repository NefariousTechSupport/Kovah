namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpMotion
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 centerOfMassAndMassFactor;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_QUATERNION, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Quaternion orientation;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_HALF, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.FLAGS_NONE)]
		private Half inverseInertia;
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint firstAttachedBodyId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private uint solverId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_HALF, hkClassMember.Type.TYPE_VOID, 3, hkClassMember.FlagValues.ALIGN_16)]
		private Half linearVelocityCage;
		[HavokMember(EVersion.hk_2014_1_0_r1, 54, null, null, hkClassMember.Type.TYPE_HALF, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Half integrationFactor;
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort motionPropertiesId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 58, null, null, hkClassMember.Type.TYPE_HALF, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Half maxLinearAccelerationDistancePerStep;
		[HavokMember(EVersion.hk_2014_1_0_r1, 60, null, null, hkClassMember.Type.TYPE_HALF, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Half maxRotationToPreventTunneling;
		[HavokMember(EVersion.hk_2014_1_0_r1, 62, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte cellIndex;
		[HavokMember(EVersion.hk_2014_1_0_r1, 63, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte spaceSplitterWeight;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 linearVelocity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 angularVelocity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 previousStepLinearVelocity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 previousStepAngularVelocity;
	}
}
