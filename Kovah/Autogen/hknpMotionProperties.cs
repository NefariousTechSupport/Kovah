namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpMotionProperties
	{
		public enum FlagsEnum
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			NEVER_REBUILD_MASS_PROPERTIES,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 536870912)]
			ENABLE_GRAVITY_MODIFICATION,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1073741824)]
			ENABLE_TIME_FACTOR,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, -536870912)]
			FLAGS_MASK,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 66060288)]
			AUTO_FLAGS_MASK,
			
		}
		public enum SolverStabilizationType
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			SOLVER_STABILIZATION_OFF,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			SOLVER_STABILIZATION_LOW,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			SOLVER_STABILIZATION_MEDIUM,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			SOLVER_STABILIZATION_HIGH,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			SOLVER_STABILIZATION_AGGRESSIVE,
			
		}
		public enum DeactivationStrategy
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			DEACTIVATION_STRATEGY_AGGRESSIVE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			DEACTIVATION_STRATEGY_BALANCED,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			DEACTIVATION_STRATEGY_ACCURATE,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.ALIGN_16)]
		private uint isExclusive;
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, typeof(hknpMotionProperties.FlagsEnum), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_UINT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpMotionProperties.FlagsEnum flags;
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float gravityFactor;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float timeFactor;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float maxLinearSpeed;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float maxAngularSpeed;
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float linearDamping;
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float angularDamping;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float solverStabilizationSpeedThreshold;
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float solverStabilizationSpeedReduction;
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float maxDistSqrd;
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float maxRotSqrd;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float invBlockSize;
		[HavokMember(EVersion.hk_2014_1_0_r1, 52, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short pathingUpperThreshold;
		[HavokMember(EVersion.hk_2014_1_0_r1, 54, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short pathingLowerThreshold;
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte numDeactivationFrequencyPasses;
		[HavokMember(EVersion.hk_2014_1_0_r1, 57, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte deactivationVelocityScaleSquare;
		[HavokMember(EVersion.hk_2014_1_0_r1, 58, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte minimumPathingVelocityScaleSquare;
		[HavokMember(EVersion.hk_2014_1_0_r1, 59, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte spikingVelocityScaleThresholdSquared;
		[HavokMember(EVersion.hk_2014_1_0_r1, 60, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte minimumSpikingVelocityScaleSquared;
	}
}
