namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpRagdollConstraintDataAtoms
	{
		public enum Axis
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			AXIS_TWIST,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			AXIS_PLANES,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			AXIS_CROSS_PRODUCT,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkpSetLocalTransformsConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkpSetLocalTransformsConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpSetLocalTransformsConstraintAtom? transforms;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, typeof(hkpSetupStabilizationAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, typeof(hkpSetupStabilizationAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpSetupStabilizationAtom? setupStabilization;
		[HavokMember(EVersion.hk_2012_1_0_r1, 160, typeof(hkpRagdollMotorConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 160, typeof(hkpRagdollMotorConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpRagdollMotorConstraintAtom? ragdollMotors;
		[HavokMember(EVersion.hk_2012_1_0_r1, 240, typeof(hkpAngFrictionConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 240, typeof(hkpAngFrictionConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpAngFrictionConstraintAtom? angFriction;
		[HavokMember(EVersion.hk_2012_1_0_r1, 256, typeof(hkpTwistLimitConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 256, typeof(hkpTwistLimitConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpTwistLimitConstraintAtom? twistLimit;
		[HavokMember(EVersion.hk_2012_1_0_r1, 288, typeof(hkpConeLimitConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 288, typeof(hkpConeLimitConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpConeLimitConstraintAtom? coneLimit;
		[HavokMember(EVersion.hk_2012_1_0_r1, 320, typeof(hkpConeLimitConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 320, typeof(hkpConeLimitConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpConeLimitConstraintAtom? planesLimit;
		[HavokMember(EVersion.hk_2012_1_0_r1, 352, typeof(hkpBallSocketConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 352, typeof(hkpBallSocketConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpBallSocketConstraintAtom? ballSocket;
	}
}
