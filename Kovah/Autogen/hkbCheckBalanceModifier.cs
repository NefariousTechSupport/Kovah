namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbCheckBalanceModifier : hkbModifier
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short ragdollLeftFootBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 50, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short ragdollRightFootBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float balanceOnAnklesFraction;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, typeof(hkbEvent), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbEvent? eventToSendWhenOffBalance;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float offBalanceEventThreshold;
		[HavokMember(EVersion.hk_2012_1_0_r1, 72, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int worldUpAxisIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 76, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float comBiasX;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool extractRagdollPose;
		[HavokMember(EVersion.hk_2012_1_0_r1, 84, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private float mass;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private Vector4 comWS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private Vector4 desiredComWS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private float offBalanceDistance;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private Vector4 errorMS;
	}
}
