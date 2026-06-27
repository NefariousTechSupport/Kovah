namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbExtrapolatingTransitionEffectInternalState : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkbGeneratorSyncInfo), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkbGeneratorSyncInfo), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbGeneratorSyncInfo? fromGeneratorSyncInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 172, typeof(hkbGeneratorPartitionInfo), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 172, typeof(hkbGeneratorPartitionInfo), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbGeneratorPartitionInfo? fromGeneratorPartitionInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 224, null, null, hkClassMember.Type.TYPE_QSTRANSFORM, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 224, null, null, hkClassMember.Type.TYPE_QSTRANSFORM, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Matrix3x4 worldFromModel;
		[HavokMember(EVersion.hk_2012_1_0_r1, 272, null, null, hkClassMember.Type.TYPE_QSTRANSFORM, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 272, null, null, hkClassMember.Type.TYPE_QSTRANSFORM, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Matrix3x4 motion;
		[HavokMember(EVersion.hk_2012_1_0_r1, 320, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_QSTRANSFORM, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 320, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_QSTRANSFORM, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Matrix3x4[]? pose;
		[HavokMember(EVersion.hk_2012_1_0_r1, 332, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_QSTRANSFORM, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 332, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_QSTRANSFORM, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Matrix3x4[]? additivePose;
		[HavokMember(EVersion.hk_2012_1_0_r1, 344, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_REAL, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 344, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_REAL, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float[]? boneWeights;
		[HavokMember(EVersion.hk_2012_1_0_r1, 356, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 356, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float toGeneratorDuration;
		[HavokMember(EVersion.hk_2012_1_0_r1, 360, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 360, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool isFromGeneratorActive;
		[HavokMember(EVersion.hk_2012_1_0_r1, 361, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 361, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool gotPose;
		[HavokMember(EVersion.hk_2012_1_0_r1, 362, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 362, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool gotAdditivePose;
	}
}
