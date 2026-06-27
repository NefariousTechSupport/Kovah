namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpLinearClearanceConstraintDataAtoms
	{
		public enum Axis
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			AXIS_SHAFT,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			AXIS_PERP_TO_SHAFT,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkpSetLocalTransformsConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpSetLocalTransformsConstraintAtom? transforms;
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, typeof(hkpLinMotorConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpLinMotorConstraintAtom? motor;
		[HavokMember(EVersion.hk_2014_1_0_r1, 160, typeof(hkpLinFrictionConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpLinFrictionConstraintAtom? friction0;
		[HavokMember(EVersion.hk_2014_1_0_r1, 176, typeof(hkpLinFrictionConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpLinFrictionConstraintAtom? friction1;
		[HavokMember(EVersion.hk_2014_1_0_r1, 192, typeof(hkpLinFrictionConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpLinFrictionConstraintAtom? friction2;
		[HavokMember(EVersion.hk_2014_1_0_r1, 208, typeof(hkpAngConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpAngConstraintAtom? ang;
		[HavokMember(EVersion.hk_2014_1_0_r1, 224, typeof(hkpLinLimitConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpLinLimitConstraintAtom? linLimit0;
		[HavokMember(EVersion.hk_2014_1_0_r1, 240, typeof(hkpLinLimitConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpLinLimitConstraintAtom? linLimit1;
		[HavokMember(EVersion.hk_2014_1_0_r1, 256, typeof(hkpLinLimitConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpLinLimitConstraintAtom? linLimit2;
	}
}
