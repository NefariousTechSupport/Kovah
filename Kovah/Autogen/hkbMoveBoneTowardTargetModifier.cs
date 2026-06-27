namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbMoveBoneTowardTargetModifier : hkbModifier
	{
		public enum TargetModeMBTT
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			TARGET_POSITION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			TARGET_COM,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			TARGET_CONTACT_POINT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			TARGET_SHAPE_CENTROID,
			
		}
		public enum AlignModeBits
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			ALIGN_AXES,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			ALIGN_BONE_AXIS_WITH_CONTACT_NORMAL,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			ALIGN_WITH_CHARACTER_FORWARD,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkbTarget), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbTarget? targetIn;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 offsetInBoneSpace;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 alignAxisBS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 targetAlignAxisTS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 alignWithCharacterForwardBS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 currentBonePositionOut;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion currentBoneRotationOut;
		[HavokMember(EVersion.hk_2012_1_0_r1, 160, typeof(hkbEventProperty), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbEventProperty? eventToSendWhenTargetReached;
		[HavokMember(EVersion.hk_2012_1_0_r1, 168, typeof(hkbGenerator), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbGenerator? childGenerator;
		[HavokMember(EVersion.hk_2012_1_0_r1, 172, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float duration;
		[HavokMember(EVersion.hk_2012_1_0_r1, 176, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short ragdollBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 178, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short animationBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 180, null, typeof(hkbMoveBoneTowardTargetModifier.TargetModeMBTT), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbMoveBoneTowardTargetModifier.TargetModeMBTT targetMode;
		[HavokMember(EVersion.hk_2012_1_0_r1, 181, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private sbyte alignMode;
		[HavokMember(EVersion.hk_2012_1_0_r1, 182, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool useVelocityPrediction;
		[HavokMember(EVersion.hk_2012_1_0_r1, 183, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool affectOrientation;
		[HavokMember(EVersion.hk_2012_1_0_r1, 184, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool currentBoneIsValidOut;
		[HavokMember(EVersion.hk_2012_1_0_r1, 188, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ targetInternal;
		[HavokMember(EVersion.hk_2012_1_0_r1, 192, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private Vector4 targetPointTS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 208, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private float time;
		[HavokMember(EVersion.hk_2012_1_0_r1, 212, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private float timeSinceLastModify;
		[HavokMember(EVersion.hk_2012_1_0_r1, 224, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private Vector4 lastAnimBonePositionMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 240, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 finalAnimBonePositionMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 256, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 initialAnimBonePositionMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 272, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion finalAnimBoneOrientationMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 288, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion animationFromRagdoll;
		[HavokMember(EVersion.hk_2012_1_0_r1, 304, null, null, Type.TYPE_QSTRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Matrix3x4 totalMotion;
		[HavokMember(EVersion.hk_2012_1_0_r1, 352, null, null, Type.TYPE_QSTRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Matrix3x4 accumulatedMotion;
		[HavokMember(EVersion.hk_2012_1_0_r1, 400, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool useAnimationData;
	}
}
