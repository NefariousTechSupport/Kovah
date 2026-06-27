namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbCheckBalanceModifier : hkbModifier
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short ragdollLeftFootBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 50, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short ragdollRightFootBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float balanceOnAnklesFraction;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, typeof(hkbEvent), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbEvent? eventToSendWhenOffBalance;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float offBalanceEventThreshold;
		[HavokMember(EVersion.hk_2012_1_0_r1, 72, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int worldUpAxisIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 76, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float comBiasX;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool extractRagdollPose;
		[HavokMember(EVersion.hk_2012_1_0_r1, 84, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private float mass;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private Vector4 comWS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private Vector4 desiredComWS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private float offBalanceDistance;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private Vector4 errorMS;
	}
}
