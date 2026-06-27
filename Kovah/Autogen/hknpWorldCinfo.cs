namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpWorldCinfo
	{
		public enum SimulationType
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			SIMULATION_TYPE_SINGLE_THREADED,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			SIMULATION_TYPE_MULTI_THREADED,
			
		}
		public enum LeavingBroadPhaseBehavior
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			ON_LEAVING_BROAD_PHASE_DO_NOTHING,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			ON_LEAVING_BROAD_PHASE_REMOVE_BODY,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			ON_LEAVING_BROAD_PHASE_FREEZE_BODY,
			
		}
		public enum SolverType
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			SOLVER_TYPE_INVALID,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			SOLVER_TYPE_2ITERS_SOFT,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			SOLVER_TYPE_2ITERS_MEDIUM,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			SOLVER_TYPE_2ITERS_HARD,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			SOLVER_TYPE_4ITERS_SOFT,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			SOLVER_TYPE_4ITERS_MEDIUM,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 6)]
			SOLVER_TYPE_4ITERS_HARD,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 7)]
			SOLVER_TYPE_8ITERS_SOFT,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			SOLVER_TYPE_8ITERS_MEDIUM,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 9)]
			SOLVER_TYPE_8ITERS_HARD,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 10)]
			SOLVER_TYPE_MAX,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int bodyBufferCapacity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ userBodyBuffer;
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int motionBufferCapacity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ userMotionBuffer;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int constraintBufferCapacity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ userConstraintBuffer;
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ persistentStreamAllocator;
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, typeof(hknpMaterialLibrary), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpMaterialLibrary? materialLibrary;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, typeof(hknpMotionPropertiesLibrary), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpMotionPropertiesLibrary? motionPropertiesLibrary;
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, typeof(hknpBodyQualityLibrary), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpBodyQualityLibrary? qualityLibrary;
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, typeof(hknpWorldCinfo.SimulationType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpWorldCinfo.SimulationType simulationType;
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int numSplitterCells;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 gravity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool enableContactCaching;
		[HavokMember(EVersion.hk_2014_1_0_r1, 65, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool mergeEventsBeforeDispatch;
		[HavokMember(EVersion.hk_2014_1_0_r1, 66, null, typeof(hknpWorldCinfo.LeavingBroadPhaseBehavior), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpWorldCinfo.LeavingBroadPhaseBehavior leavingBroadPhaseBehavior;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, typeof(hkAabb), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkAabb? broadPhaseAabb;
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, typeof(hknpBroadPhaseConfig), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpBroadPhaseConfig? broadPhaseConfig;
		[HavokMember(EVersion.hk_2014_1_0_r1, 116, typeof(hknpCollisionFilter), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpCollisionFilter? collisionFilter;
		[HavokMember(EVersion.hk_2014_1_0_r1, 120, typeof(hknpShapeTagCodec), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpShapeTagCodec? shapeTagCodec;
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float collisionTolerance;
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float relativeCollisionAccuracy;
		[HavokMember(EVersion.hk_2014_1_0_r1, 132, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool enableWeldingForDefaultObjects;
		[HavokMember(EVersion.hk_2014_1_0_r1, 133, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool enableWeldingForCriticalObjects;
		[HavokMember(EVersion.hk_2014_1_0_r1, 136, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float solverTau;
		[HavokMember(EVersion.hk_2014_1_0_r1, 140, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float solverDamp;
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int solverIterations;
		[HavokMember(EVersion.hk_2014_1_0_r1, 148, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int solverMicrosteps;
		[HavokMember(EVersion.hk_2014_1_0_r1, 152, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float defaultSolverTimestep;
		[HavokMember(EVersion.hk_2014_1_0_r1, 156, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float maxApproachSpeedForHighQualitySolver;
		[HavokMember(EVersion.hk_2014_1_0_r1, 160, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool enableDeactivation;
		[HavokMember(EVersion.hk_2014_1_0_r1, 161, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool deleteCachesOnDeactivation;
		[HavokMember(EVersion.hk_2014_1_0_r1, 164, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int largeIslandSize;
		[HavokMember(EVersion.hk_2014_1_0_r1, 168, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool enableSolverDynamicScheduling;
		[HavokMember(EVersion.hk_2014_1_0_r1, 172, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int contactSolverType;
		[HavokMember(EVersion.hk_2014_1_0_r1, 176, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float unitScale;
		[HavokMember(EVersion.hk_2014_1_0_r1, 180, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool applyUnitScaleToStaticConstants;
	}
}
