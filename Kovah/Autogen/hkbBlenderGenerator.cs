namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbBlenderGenerator : hkbGenerator
	{
		public enum BlenderFlags
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			FLAG_SYNC,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			FLAG_SMOOTH_GENERATOR_WEIGHTS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			FLAG_DONT_DEACTIVATE_CHILDREN_WITH_ZERO_WEIGHTS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			FLAG_PARAMETRIC_BLEND,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 32)]
			FLAG_IS_PARAMETRIC_BLEND_CYCLIC,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 64)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 64)]
			FLAG_FORCE_DENSE_POSE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 128)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 128)]
			FLAG_BLEND_MOTION_OF_ADDITIVE_ANIMATIONS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 256)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 256)]
			FLAG_USE_VELOCITY_SYNCHRONIZATION,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float referencePoseWeightThreshold;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float blendParameter;
		[HavokMember(EVersion.hk_2012_1_0_r1, 100, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 100, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float minCyclicBlendParameter;
		[HavokMember(EVersion.hk_2012_1_0_r1, 104, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 104, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float maxCyclicBlendParameter;
		[HavokMember(EVersion.hk_2012_1_0_r1, 108, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 108, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short indexOfSyncMasterChild;
		[HavokMember(EVersion.hk_2012_1_0_r1, 110, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 110, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short flags;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool subtractLastChild;
		[HavokMember(EVersion.hk_2012_1_0_r1, 116, typeof(hkbBlenderGeneratorChild), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 116, typeof(hkbBlenderGeneratorChild), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? children;
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? childrenInternalStates;
		[HavokMember(EVersion.hk_2012_1_0_r1, 140, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 140, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? sortedChildren;
		[HavokMember(EVersion.hk_2012_1_0_r1, 152, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 152, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private float endIntervalWeight;
		[HavokMember(EVersion.hk_2012_1_0_r1, 156, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 156, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private int numActiveChildren;
		[HavokMember(EVersion.hk_2012_1_0_r1, 160, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 160, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private short beginIntervalIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 162, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 162, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private short endIntervalIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 164, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 164, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private bool initSync;
		[HavokMember(EVersion.hk_2012_1_0_r1, 165, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 165, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private bool doSubtractiveBlend;
	}
}
