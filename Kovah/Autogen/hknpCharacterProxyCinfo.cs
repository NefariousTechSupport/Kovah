namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpCharacterProxyCinfo : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 position;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion orientation;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 velocity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float dynamicFriction;
		[HavokMember(EVersion.hk_2014_1_0_r1, 68, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float staticFriction;
		[HavokMember(EVersion.hk_2014_1_0_r1, 72, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float keepContactTolerance;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 up;
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, typeof(hknpShape), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpShape? shape;
		[HavokMember(EVersion.hk_2014_1_0_r1, 104, null, null, Type.TYPE_UINT64, Type.TYPE_VOID, 0, FlagValues.ALIGN_8)]
		private ulong userData;
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ world;
		[HavokMember(EVersion.hk_2014_1_0_r1, 116, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint collisionFilterInfo;
		[HavokMember(EVersion.hk_2014_1_0_r1, 120, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float keepDistance;
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float contactAngleSensitivity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint userPlanes;
		[HavokMember(EVersion.hk_2014_1_0_r1, 132, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float maxCharacterSpeedForSolver;
		[HavokMember(EVersion.hk_2014_1_0_r1, 136, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float characterStrength;
		[HavokMember(EVersion.hk_2014_1_0_r1, 140, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float characterMass;
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float maxSlope;
		[HavokMember(EVersion.hk_2014_1_0_r1, 148, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float penetrationRecoverySpeed;
		[HavokMember(EVersion.hk_2014_1_0_r1, 152, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int maxCastIterations;
		[HavokMember(EVersion.hk_2014_1_0_r1, 156, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool refreshManifoldInCheckSupport;
		[HavokMember(EVersion.hk_2014_1_0_r1, 157, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool presenceInWorld;
	}
}
