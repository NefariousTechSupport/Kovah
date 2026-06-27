namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbBlendingTransitionEffectInternalState : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 fromPos;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion fromRot;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 toPos;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion toRot;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 lastPos;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion lastRot;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, Type.TYPE_ARRAY, Type.TYPE_QSTRANSFORM, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, Type.TYPE_ARRAY, Type.TYPE_QSTRANSFORM, 0, FlagValues.FLAGS_NONE)]
		private Matrix3x4[]? characterPoseAtBeginningOfTransition;
		[HavokMember(EVersion.hk_2012_1_0_r1, 124, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float timeRemaining;
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float timeInTransition;
		[HavokMember(EVersion.hk_2012_1_0_r1, 132, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool applySelfTransition;
		[HavokMember(EVersion.hk_2012_1_0_r1, 133, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 133, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool initializeCharacterPose;
		[HavokMember(EVersion.hk_2012_1_0_r1, 134, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 134, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool alignThisFrame;
		[HavokMember(EVersion.hk_2012_1_0_r1, 135, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 135, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool alignmentFinished;
		[HavokMember(EVersion.hk_2014_1_0_r1, 132, null, typeof(hkbTransitionEffect.SelfTransitionMode), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbTransitionEffect.SelfTransitionMode toGeneratorSelfTranstitionMode;
	}
}
