namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbCatchFallModifier : hkbModifier
	{
		public enum FadeState
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			FADE_IN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			FADE_OUT,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 directionOfFallForwardLS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 directionOfFallRightLS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 directionOfFallUpLS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, typeof(hkbBoneIndexArray), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbBoneIndexArray? spineIndices;
		[HavokMember(EVersion.hk_2012_1_0_r1, 100, typeof(hkbCatchFallModifierHand), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbCatchFallModifierHand? leftHand;
		[HavokMember(EVersion.hk_2012_1_0_r1, 106, typeof(hkbCatchFallModifierHand), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbCatchFallModifierHand? rightHand;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, typeof(hkbEventProperty), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbEventProperty? catchFallDoneEvent;
		[HavokMember(EVersion.hk_2012_1_0_r1, 120, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float spreadHandsMultiplier;
		[HavokMember(EVersion.hk_2012_1_0_r1, 124, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float radarRange;
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float previousTargetBlendWeight;
		[HavokMember(EVersion.hk_2012_1_0_r1, 132, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float handsBendDistance;
		[HavokMember(EVersion.hk_2012_1_0_r1, 136, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float maxReachDistanceForward;
		[HavokMember(EVersion.hk_2012_1_0_r1, 140, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float maxReachDistanceBackward;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float fadeInReachGainSpeed;
		[HavokMember(EVersion.hk_2012_1_0_r1, 148, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float fadeOutReachGainSpeed;
		[HavokMember(EVersion.hk_2012_1_0_r1, 152, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float fadeOutDuration;
		[HavokMember(EVersion.hk_2012_1_0_r1, 156, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float fadeInTwistSpeed;
		[HavokMember(EVersion.hk_2012_1_0_r1, 160, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float fadeOutTwistSpeed;
		[HavokMember(EVersion.hk_2012_1_0_r1, 164, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short raycastLayer;
		[HavokMember(EVersion.hk_2012_1_0_r1, 166, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short velocityRagdollBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 168, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short directionOfFallRagdollBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 170, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool orientHands;
		[HavokMember(EVersion.hk_2012_1_0_r1, 176, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private Vector4 catchFallPosInBS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 208, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private float currentReachGain;
		[HavokMember(EVersion.hk_2012_1_0_r1, 216, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float timeSinceLastModify;
		[HavokMember(EVersion.hk_2012_1_0_r1, 220, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float currentTwistGain;
		[HavokMember(EVersion.hk_2012_1_0_r1, 224, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short currentTwistDirection;
		[HavokMember(EVersion.hk_2012_1_0_r1, 226, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private bool catchFallPosIsValid;
		[HavokMember(EVersion.hk_2012_1_0_r1, 228, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool catchFallBegin;
		[HavokMember(EVersion.hk_2012_1_0_r1, 229, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool catchFallEnd;
		[HavokMember(EVersion.hk_2012_1_0_r1, 230, null, null, Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.SERIALIZE_IGNORED)]
		private sbyte fadeState;
	}
}
