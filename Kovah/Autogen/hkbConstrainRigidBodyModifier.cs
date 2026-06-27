namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbConstrainRigidBodyModifier : hkbModifier
	{
		public enum PivotPlacement
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			PIVOT_MIDWAY_BETWEEN_CENTROIDS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			PIVOT_AT_TARGET_CONTACT_POINT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			PIVOT_MIDWAY_BETWEEN_TARGET_SHAPE_CENTROID_AND_BODY_TO_CONSTRAIN_CENTROID,
			
		}
		public enum BoneToConstrainPlacement
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			BTCP_AT_CURRENT_POSITION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			BTCP_ALIGN_COM_AND_PIVOT,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkbTarget), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbTarget? targetIn;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float breakThreshold;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short ragdollBoneToConstrain;
		[HavokMember(EVersion.hk_2012_1_0_r1, 58, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool breakable;
		[HavokMember(EVersion.hk_2012_1_0_r1, 59, null, typeof(hkbConstrainRigidBodyModifier.PivotPlacement), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbConstrainRigidBodyModifier.PivotPlacement pivotPlacement;
		[HavokMember(EVersion.hk_2012_1_0_r1, 60, null, typeof(hkbConstrainRigidBodyModifier.BoneToConstrainPlacement), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbConstrainRigidBodyModifier.BoneToConstrainPlacement boneToConstrainPlacement;
		[HavokMember(EVersion.hk_2012_1_0_r1, 61, null, typeof(hkpConstraintData.ConstraintType), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkpConstraintData.ConstraintType constraintType;
		[HavokMember(EVersion.hk_2012_1_0_r1, 62, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool clearTargetData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 63, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool isConstraintHinge;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ constraint;
	}
}
