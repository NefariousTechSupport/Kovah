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
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkpSetLocalTransformsConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpSetLocalTransformsConstraintAtom? transforms;
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, typeof(hkpLinMotorConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpLinMotorConstraintAtom? motor;
		[HavokMember(EVersion.hk_2014_1_0_r1, 160, typeof(hkpLinFrictionConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpLinFrictionConstraintAtom? friction0;
		[HavokMember(EVersion.hk_2014_1_0_r1, 176, typeof(hkpLinFrictionConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpLinFrictionConstraintAtom? friction1;
		[HavokMember(EVersion.hk_2014_1_0_r1, 192, typeof(hkpLinFrictionConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpLinFrictionConstraintAtom? friction2;
		[HavokMember(EVersion.hk_2014_1_0_r1, 208, typeof(hkpAngConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpAngConstraintAtom? ang;
		[HavokMember(EVersion.hk_2014_1_0_r1, 224, typeof(hkpLinLimitConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpLinLimitConstraintAtom? linLimit0;
		[HavokMember(EVersion.hk_2014_1_0_r1, 240, typeof(hkpLinLimitConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpLinLimitConstraintAtom? linLimit1;
		[HavokMember(EVersion.hk_2014_1_0_r1, 256, typeof(hkpLinLimitConstraintAtom), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpLinLimitConstraintAtom? linLimit2;
	}
}
