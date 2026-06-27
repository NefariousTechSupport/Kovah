namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	public partial class hkpWorldCinfo : hkReferencedObject
	{
		public enum BroadPhaseBorderBehaviour
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			BROADPHASE_BORDER_ASSERT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			BROADPHASE_BORDER_FIX_ENTITY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			BROADPHASE_BORDER_REMOVE_ENTITY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 3)]
			BROADPHASE_BORDER_DO_NOTHING,
			
		}
		public enum TreeUpdateType
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			REBUILD_ACTIVE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			REBUILD_ALL,
			
		}
		public enum ContactPointGeneration
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			CONTACT_POINT_ACCEPT_ALWAYS,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			CONTACT_POINT_REJECT_DUBIOUS,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			CONTACT_POINT_REJECT_MANY,
			
		}
		public enum SimulationType
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			SIMULATION_TYPE_INVALID,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			SIMULATION_TYPE_DISCRETE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			SIMULATION_TYPE_CONTINUOUS,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 3)]
			SIMULATION_TYPE_MULTITHREADED,
			
		}
		public enum SolverType
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			SOLVER_TYPE_INVALID,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			SOLVER_TYPE_2ITERS_SOFT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			SOLVER_TYPE_2ITERS_MEDIUM,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 3)]
			SOLVER_TYPE_2ITERS_HARD,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 4)]
			SOLVER_TYPE_4ITERS_SOFT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 5)]
			SOLVER_TYPE_4ITERS_MEDIUM,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 6)]
			SOLVER_TYPE_4ITERS_HARD,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 7)]
			SOLVER_TYPE_8ITERS_SOFT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 8)]
			SOLVER_TYPE_8ITERS_MEDIUM,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 9)]
			SOLVER_TYPE_8ITERS_HARD,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 10)]
			SOLVER_TYPE_MAX_ID,
			
		}
		public enum BroadPhaseType
		{
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			BROADPHASE_TYPE_SAP,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			BROADPHASE_TYPE_TREE,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			BROADPHASE_TYPE_HYBRID,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 3)]
			BROADPHASE_TYPE_SAP_AND_KD_TREE_DEPRECATED,
			
		}
		[HavokMember(EVersion.Havok_7_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 gravity;
		[HavokMember(EVersion.Havok_7_1_0_r1, 32, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 32, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 32, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int broadPhaseQuerySize;
		[HavokMember(EVersion.Havok_7_1_0_r1, 36, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 36, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 36, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float contactRestingVelocity;
		[HavokMember(EVersion.Havok_7_1_0_r1, 40, null, typeof(hkpWorldCinfo.BroadPhaseBorderBehaviour), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 41, null, typeof(hkpWorldCinfo.BroadPhaseBorderBehaviour), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 41, null, typeof(hkpWorldCinfo.BroadPhaseBorderBehaviour), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 41, null, typeof(hkpWorldCinfo.BroadPhaseBorderBehaviour), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkpWorldCinfo.BroadPhaseBorderBehaviour broadPhaseBorderBehaviour;
		[HavokMember(EVersion.Havok_7_1_0_r1, 41, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 42, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 42, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 42, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool mtPostponeAndSortBroadPhaseBorderCallbacks;
		[HavokMember(EVersion.Havok_7_1_0_r1, 48, typeof(hkAabb), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 48, typeof(hkAabb), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkAabb), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 48, typeof(hkAabb), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkAabb? broadPhaseWorldAabb;
		[HavokMember(EVersion.Havok_7_1_0_r1, 80, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool useKdTree;
		[HavokMember(EVersion.Havok_7_1_0_r1, 81, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool useMultipleTree;
		[HavokMember(EVersion.Havok_7_1_0_r1, 82, null, typeof(hkpWorldCinfo.TreeUpdateType), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkpWorldCinfo.TreeUpdateType treeUpdateType;
		[HavokMember(EVersion.Havok_7_1_0_r1, 83, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 80, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool autoUpdateKdTree;
		[HavokMember(EVersion.Havok_7_1_0_r1, 84, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 84, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 80, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float collisionTolerance;
		[HavokMember(EVersion.Havok_7_1_0_r1, 88, typeof(hkpCollisionFilter), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 88, typeof(hkpCollisionFilter), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 84, typeof(hkpCollisionFilter), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 84, typeof(hkpCollisionFilter), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpCollisionFilter? collisionFilter;
		[HavokMember(EVersion.Havok_7_1_0_r1, 92, typeof(hkpConvexListFilter), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 92, typeof(hkpConvexListFilter), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 88, typeof(hkpConvexListFilter), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 88, typeof(hkpConvexListFilter), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpConvexListFilter? convexListFilter;
		[HavokMember(EVersion.Havok_7_1_0_r1, 96, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 96, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 92, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float expectedMaxLinearVelocity;
		[HavokMember(EVersion.Havok_7_1_0_r1, 100, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 100, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 96, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int sizeOfToiEventQueue;
		[HavokMember(EVersion.Havok_7_1_0_r1, 104, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 104, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 100, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 100, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float expectedMinPsiDeltaTime;
		[HavokMember(EVersion.Havok_7_1_0_r1, 108, typeof(hkWorldMemoryAvailableWatchDog), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 108, typeof(hkWorldMemoryAvailableWatchDog), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 104, typeof(hkWorldMemoryAvailableWatchDog), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 104, typeof(hkWorldMemoryAvailableWatchDog), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkWorldMemoryAvailableWatchDog? memoryWatchDog;
		[HavokMember(EVersion.Havok_7_1_0_r1, 112, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 112, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 108, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 108, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int broadPhaseNumMarkers;
		[HavokMember(EVersion.Havok_7_1_0_r1, 116, null, typeof(hkpWorldCinfo.ContactPointGeneration), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 116, null, typeof(hkpWorldCinfo.ContactPointGeneration), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, typeof(hkpWorldCinfo.ContactPointGeneration), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 112, null, typeof(hkpWorldCinfo.ContactPointGeneration), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkpWorldCinfo.ContactPointGeneration contactPointGeneration;
		[HavokMember(EVersion.Havok_7_1_0_r1, 117, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 117, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 113, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 113, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool allowToSkipConfirmedCallbacks;
		[HavokMember(EVersion.Havok_7_1_0_r1, 120, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 120, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 116, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 116, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float solverTau;
		[HavokMember(EVersion.Havok_7_1_0_r1, 124, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 124, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 120, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 120, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float solverDamp;
		[HavokMember(EVersion.Havok_7_1_0_r1, 128, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 128, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 124, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 124, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int solverIterations;
		[HavokMember(EVersion.Havok_7_1_0_r1, 132, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 132, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 128, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int solverMicrosteps;
		[HavokMember(EVersion.Havok_7_1_0_r1, 136, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 136, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 132, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 132, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float maxConstraintViolation;
		[HavokMember(EVersion.Havok_7_1_0_r1, 140, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 140, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 136, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 136, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool forceCoherentConstraintOrderingInSolver;
		[HavokMember(EVersion.Havok_7_1_0_r1, 144, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 144, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 140, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 140, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float snapCollisionToConvexEdgeThreshold;
		[HavokMember(EVersion.Havok_7_1_0_r1, 148, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 148, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 144, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float snapCollisionToConcaveEdgeThreshold;
		[HavokMember(EVersion.Havok_7_1_0_r1, 152, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 152, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 148, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 148, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool enableToiWeldRejection;
		[HavokMember(EVersion.Havok_7_1_0_r1, 153, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 153, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 149, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 149, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool enableDeprecatedWelding;
		[HavokMember(EVersion.Havok_7_1_0_r1, 156, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 156, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 152, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 152, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float iterativeLinearCastEarlyOutDistance;
		[HavokMember(EVersion.Havok_7_1_0_r1, 160, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 160, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 156, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 156, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int iterativeLinearCastMaxIterations;
		[HavokMember(EVersion.Havok_7_1_0_r1, 164, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 164, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 160, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 160, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte deactivationNumInactiveFramesSelectFlag0;
		[HavokMember(EVersion.Havok_7_1_0_r1, 165, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 165, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 161, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 161, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte deactivationNumInactiveFramesSelectFlag1;
		[HavokMember(EVersion.Havok_7_1_0_r1, 166, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 166, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 162, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 162, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte deactivationIntegrateCounter;
		[HavokMember(EVersion.Havok_7_1_0_r1, 167, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 167, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 163, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 163, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool shouldActivateOnRigidBodyTransformChange;
		[HavokMember(EVersion.Havok_7_1_0_r1, 168, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 168, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 164, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 164, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float deactivationReferenceDistance;
		[HavokMember(EVersion.Havok_7_1_0_r1, 172, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 172, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 168, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 168, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float toiCollisionResponseRotateNormal;
		[HavokMember(EVersion.Havok_7_1_0_r1, 176, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int maxSectorsPerCollideTask;
		[HavokMember(EVersion.Havok_7_1_0_r1, 180, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 188, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 184, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 184, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool processToisMultithreaded;
		[HavokMember(EVersion.Havok_7_1_0_r1, 184, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int maxEntriesPerToiCollideTask;
		[HavokMember(EVersion.Havok_7_1_0_r1, 188, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 200, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 196, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 196, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int maxNumToiCollisionPairsSinglethreaded;
		[HavokMember(EVersion.Havok_7_1_0_r1, 192, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 204, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 200, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 200, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float numToisTillAllowedPenetrationSimplifiedToi;
		[HavokMember(EVersion.Havok_7_1_0_r1, 196, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 208, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 204, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 204, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float numToisTillAllowedPenetrationToi;
		[HavokMember(EVersion.Havok_7_1_0_r1, 200, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 212, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 208, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 208, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float numToisTillAllowedPenetrationToiHigher;
		[HavokMember(EVersion.Havok_7_1_0_r1, 204, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 216, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 212, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 212, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float numToisTillAllowedPenetrationToiForced;
		[HavokMember(EVersion.Havok_7_1_0_r1, 208, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 220, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 216, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 216, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool enableDeactivation;
		[HavokMember(EVersion.Havok_7_1_0_r1, 209, null, typeof(hkpWorldCinfo.SimulationType), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 221, null, typeof(hkpWorldCinfo.SimulationType), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 217, null, typeof(hkpWorldCinfo.SimulationType), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 217, null, typeof(hkpWorldCinfo.SimulationType), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkpWorldCinfo.SimulationType simulationType;
		[HavokMember(EVersion.Havok_7_1_0_r1, 210, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 222, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 218, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 218, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool enableSimulationIslands;
		[HavokMember(EVersion.Havok_7_1_0_r1, 212, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 224, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 220, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 220, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint minDesiredIslandSize;
		[HavokMember(EVersion.Havok_7_1_0_r1, 216, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 228, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 224, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 224, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool processActionsInSingleThread;
		[HavokMember(EVersion.Havok_7_1_0_r1, 217, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 229, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 225, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 225, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool allowIntegrationOfIslandsWithoutConstraintsInASeparateJob;
		[HavokMember(EVersion.Havok_7_1_0_r1, 220, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 232, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 228, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 228, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float frameMarkerPsiSnap;
		[HavokMember(EVersion.Havok_7_1_0_r1, 224, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 236, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 232, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 232, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool fireCollisionCallbacks;
		[HavokMember(EVersion.hk_2011_2_0_r1, 40, null, typeof(hkpWorldCinfo.BroadPhaseType), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, typeof(hkpWorldCinfo.BroadPhaseType), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 40, null, typeof(hkpWorldCinfo.BroadPhaseType), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkpWorldCinfo.BroadPhaseType broadPhaseType;
		[HavokMember(EVersion.hk_2011_2_0_r1, 176, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool BETA_useCompoundSpuElf;
		[HavokMember(EVersion.hk_2011_2_0_r1, 180, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 176, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 176, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int maxSectorsPerMidphaseCollideTask;
		[HavokMember(EVersion.hk_2011_2_0_r1, 184, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 180, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 180, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int maxSectorsPerNarrowphaseCollideTask;
		[HavokMember(EVersion.hk_2011_2_0_r1, 192, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 188, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 188, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int maxEntriesPerToiMidphaseCollideTask;
		[HavokMember(EVersion.hk_2011_2_0_r1, 196, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 192, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 192, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int maxEntriesPerToiNarrowphaseCollideTask;
		[HavokMember(EVersion.hk_2012_1_0_r1, 172, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 172, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool useCompoundSpuElf;
	}
}
