namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbExtrapolatingTransitionEffectInternalState : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkbGeneratorSyncInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkbGeneratorSyncInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbGeneratorSyncInfo? fromGeneratorSyncInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 172, typeof(hkbGeneratorPartitionInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 172, typeof(hkbGeneratorPartitionInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbGeneratorPartitionInfo? fromGeneratorPartitionInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 224, null, null, Type.TYPE_QSTRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 224, null, null, Type.TYPE_QSTRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Matrix3x4 worldFromModel;
		[HavokMember(EVersion.hk_2012_1_0_r1, 272, null, null, Type.TYPE_QSTRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 272, null, null, Type.TYPE_QSTRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Matrix3x4 motion;
		[HavokMember(EVersion.hk_2012_1_0_r1, 320, null, null, Type.TYPE_ARRAY, Type.TYPE_QSTRANSFORM, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 320, null, null, Type.TYPE_ARRAY, Type.TYPE_QSTRANSFORM, 0, FlagValues.FLAGS_NONE)]
		private Matrix3x4[]? pose;
		[HavokMember(EVersion.hk_2012_1_0_r1, 332, null, null, Type.TYPE_ARRAY, Type.TYPE_QSTRANSFORM, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 332, null, null, Type.TYPE_ARRAY, Type.TYPE_QSTRANSFORM, 0, FlagValues.FLAGS_NONE)]
		private Matrix3x4[]? additivePose;
		[HavokMember(EVersion.hk_2012_1_0_r1, 344, null, null, Type.TYPE_ARRAY, Type.TYPE_REAL, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 344, null, null, Type.TYPE_ARRAY, Type.TYPE_REAL, 0, FlagValues.FLAGS_NONE)]
		private float[]? boneWeights;
		[HavokMember(EVersion.hk_2012_1_0_r1, 356, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 356, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float toGeneratorDuration;
		[HavokMember(EVersion.hk_2012_1_0_r1, 360, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 360, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool isFromGeneratorActive;
		[HavokMember(EVersion.hk_2012_1_0_r1, 361, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 361, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool gotPose;
		[HavokMember(EVersion.hk_2012_1_0_r1, 362, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 362, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool gotAdditivePose;
	}
}
