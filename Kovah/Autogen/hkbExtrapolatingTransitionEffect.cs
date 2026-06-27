namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbExtrapolatingTransitionEffect : hkbBlendingTransitionEffect
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 256, typeof(hkbGeneratorSyncInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 248, typeof(hkbGeneratorSyncInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private hkbGeneratorSyncInfo? fromGeneratorSyncInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 420, typeof(hkbGeneratorPartitionInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 412, typeof(hkbGeneratorPartitionInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private hkbGeneratorPartitionInfo? fromGeneratorPartitionInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 464, null, null, Type.TYPE_QSTRANSFORM, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 464, null, null, Type.TYPE_QSTRANSFORM, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private Matrix3x4 worldFromModel;
		[HavokMember(EVersion.hk_2012_1_0_r1, 512, null, null, Type.TYPE_QSTRANSFORM, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 512, null, null, Type.TYPE_QSTRANSFORM, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private Matrix3x4 motion;
		[HavokMember(EVersion.hk_2012_1_0_r1, 560, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 560, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? pose;
		[HavokMember(EVersion.hk_2012_1_0_r1, 572, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 572, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? additivePose;
		[HavokMember(EVersion.hk_2012_1_0_r1, 584, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 584, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? boneWeights;
		[HavokMember(EVersion.hk_2012_1_0_r1, 596, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 596, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private float toGeneratorDuration;
		[HavokMember(EVersion.hk_2012_1_0_r1, 600, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 600, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool isFromGeneratorActive;
		[HavokMember(EVersion.hk_2012_1_0_r1, 601, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 601, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool gotPose;
		[HavokMember(EVersion.hk_2012_1_0_r1, 602, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 602, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool gotAdditivePose;
	}
}
