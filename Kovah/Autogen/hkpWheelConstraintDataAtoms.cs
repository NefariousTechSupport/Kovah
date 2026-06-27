namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpWheelConstraintDataAtoms
	{
		public enum Axis
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			AXIS_SUSPENSION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			AXIS_PERP_SUSPENSION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			AXIS_AXLE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			AXIS_STEERING,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkpSetLocalTransformsConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkpSetLocalTransformsConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpSetLocalTransformsConstraintAtom? suspensionBase;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, typeof(hkpLinLimitConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, typeof(hkpLinLimitConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpLinLimitConstraintAtom? lin0Limit;
		[HavokMember(EVersion.hk_2012_1_0_r1, 160, typeof(hkpLinSoftConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 160, typeof(hkpLinSoftConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpLinSoftConstraintAtom? lin0Soft;
		[HavokMember(EVersion.hk_2012_1_0_r1, 176, typeof(hkpLinConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 176, typeof(hkpLinConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpLinConstraintAtom? lin1;
		[HavokMember(EVersion.hk_2012_1_0_r1, 192, typeof(hkpLinConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 192, typeof(hkpLinConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpLinConstraintAtom? lin2;
		[HavokMember(EVersion.hk_2012_1_0_r1, 208, typeof(hkpSetLocalRotationsConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 208, typeof(hkpSetLocalRotationsConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpSetLocalRotationsConstraintAtom? steeringBase;
		[HavokMember(EVersion.hk_2012_1_0_r1, 320, typeof(hkp2dAngConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 320, typeof(hkp2dAngConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkp2dAngConstraintAtom? _2dAng;
	}
}
