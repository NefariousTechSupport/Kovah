namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpLimitedHingeConstraintDataAtoms
	{
		public enum Axis
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			AXIS_AXLE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			AXIS_PERP_TO_AXLE_1,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			AXIS_PERP_TO_AXLE_2,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkpSetLocalTransformsConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkpSetLocalTransformsConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpSetLocalTransformsConstraintAtom? transforms;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, typeof(hkpSetupStabilizationAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, typeof(hkpSetupStabilizationAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpSetupStabilizationAtom? setupStabilization;
		[HavokMember(EVersion.hk_2012_1_0_r1, 160, typeof(hkpAngMotorConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 160, typeof(hkpAngMotorConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpAngMotorConstraintAtom? angMotor;
		[HavokMember(EVersion.hk_2012_1_0_r1, 192, typeof(hkpAngFrictionConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 192, typeof(hkpAngFrictionConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpAngFrictionConstraintAtom? angFriction;
		[HavokMember(EVersion.hk_2012_1_0_r1, 208, typeof(hkpAngLimitConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 208, typeof(hkpAngLimitConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpAngLimitConstraintAtom? angLimit;
		[HavokMember(EVersion.hk_2012_1_0_r1, 224, typeof(hkp2dAngConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 224, typeof(hkp2dAngConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkp2dAngConstraintAtom? _2dAng;
		[HavokMember(EVersion.hk_2012_1_0_r1, 240, typeof(hkpBallSocketConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 240, typeof(hkpBallSocketConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpBallSocketConstraintAtom? ballSocket;
	}
}
