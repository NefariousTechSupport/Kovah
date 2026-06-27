namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpHingeConstraintDataAtoms
	{
		public enum Axis
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			AXIS_AXLE,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkpSetLocalTransformsConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkpSetLocalTransformsConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpSetLocalTransformsConstraintAtom? transforms;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, typeof(hkpSetupStabilizationAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, typeof(hkpSetupStabilizationAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpSetupStabilizationAtom? setupStabilization;
		[HavokMember(EVersion.hk_2012_1_0_r1, 160, typeof(hkp2dAngConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 160, typeof(hkp2dAngConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkp2dAngConstraintAtom? _2dAng;
		[HavokMember(EVersion.hk_2012_1_0_r1, 176, typeof(hkpBallSocketConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 176, typeof(hkpBallSocketConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpBallSocketConstraintAtom? ballSocket;
	}
}
