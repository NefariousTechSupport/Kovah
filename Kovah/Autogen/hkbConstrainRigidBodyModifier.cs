namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbConstrainRigidBodyModifier : hkbModifier
	{
		public enum PivotPlacement : int
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			PIVOT_MIDWAY_BETWEEN_CENTROIDS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			PIVOT_AT_TARGET_CONTACT_POINT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			PIVOT_MIDWAY_BETWEEN_TARGET_SHAPE_CENTROID_AND_BODY_TO_CONSTRAIN_CENTROID,
			
		}
		public enum BoneToConstrainPlacement : int
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			BTCP_AT_CURRENT_POSITION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			BTCP_ALIGN_COM_AND_PIVOT,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkbTarget), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbTarget? targetIn;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float breakThreshold;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short ragdollBoneToConstrain;
		[HavokMember(EVersion.hk_2012_1_0_r1, 58, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool breakable;
		[HavokMember(EVersion.hk_2012_1_0_r1, 59, null, typeof(hkbConstrainRigidBodyModifier.PivotPlacement), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbConstrainRigidBodyModifier.PivotPlacement pivotPlacement;
		[HavokMember(EVersion.hk_2012_1_0_r1, 60, null, typeof(hkbConstrainRigidBodyModifier.BoneToConstrainPlacement), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbConstrainRigidBodyModifier.BoneToConstrainPlacement boneToConstrainPlacement;
		[HavokMember(EVersion.hk_2012_1_0_r1, 61, null, typeof(hkpConstraintData.ConstraintType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpConstraintData.ConstraintType constraintType;
		[HavokMember(EVersion.hk_2012_1_0_r1, 62, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool clearTargetData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 63, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool isConstraintHinge;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ constraint;
	}
}
