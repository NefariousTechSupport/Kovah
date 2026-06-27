namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbReachTowardTargetModifier : hkbModifier
	{
		public enum FadeState : int
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			FADE_IN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			FADE_OUT,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkbReachTowardTargetModifierHand), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbReachTowardTargetModifierHand? leftHand;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, typeof(hkbReachTowardTargetModifierHand), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbReachTowardTargetModifierHand? rightHand;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, typeof(hkbTarget), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbTarget? targetIn;
		[HavokMember(EVersion.hk_2012_1_0_r1, 60, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float distanceBetweenHands;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float reachDistance;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float fadeInGainSpeed;
		[HavokMember(EVersion.hk_2012_1_0_r1, 72, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float fadeOutGainSpeed;
		[HavokMember(EVersion.hk_2012_1_0_r1, 76, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float fadeOutDuration;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float targetChangeSpeed;
		[HavokMember(EVersion.hk_2012_1_0_r1, 84, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool holdTarget;
		[HavokMember(EVersion.hk_2012_1_0_r1, 85, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool reachPastTarget;
		[HavokMember(EVersion.hk_2012_1_0_r1, 86, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool giveUpIfNoTarget;
		[HavokMember(EVersion.hk_2012_1_0_r1, 88, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ targetRB;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private Vector4 prevTargetInMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private float currentGain;
		[HavokMember(EVersion.hk_2012_1_0_r1, 116, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private float timeSinceLastModify;
		[HavokMember(EVersion.hk_2012_1_0_r1, 120, null, null, hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private sbyte fadeState;
		[HavokMember(EVersion.hk_2012_1_0_r1, 121, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private bool haveGivenUp;
		[HavokMember(EVersion.hk_2012_1_0_r1, 122, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private bool isTherePrevTarget;
	}
}
