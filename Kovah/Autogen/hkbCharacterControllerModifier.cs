namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCharacterControllerModifier : hkbModifier
	{
		public enum InitialVelocityCoordinates
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			INITIAL_VELOCITY_IN_WORLD_COORDINATES,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			INITIAL_VELOCITY_IN_MODEL_COORDINATES,
			
		}
		public enum MotionMode
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			MOTION_MODE_FOLLOW_ANIMATION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			MOTION_MODE_DYNAMIC,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkbCharacterControllerModifierControlData), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, typeof(hkbCharacterControllerModifierControlData), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbCharacterControllerModifierControlData? controlData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 initialVelocity;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, typeof(hkbCharacterControllerModifier.InitialVelocityCoordinates), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, typeof(hkbCharacterControllerModifier.InitialVelocityCoordinates), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCharacterControllerModifier.InitialVelocityCoordinates initialVelocityCoordinates;
		[HavokMember(EVersion.hk_2012_1_0_r1, 81, null, typeof(hkbCharacterControllerModifier.MotionMode), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 81, null, typeof(hkbCharacterControllerModifier.MotionMode), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCharacterControllerModifier.MotionMode motionMode;
		[HavokMember(EVersion.hk_2012_1_0_r1, 82, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 82, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool forceDownwardMomentum;
		[HavokMember(EVersion.hk_2012_1_0_r1, 83, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 83, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool applyGravity;
		[HavokMember(EVersion.hk_2012_1_0_r1, 84, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 84, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool setInitialVelocity;
		[HavokMember(EVersion.hk_2012_1_0_r1, 85, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 85, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool isTouchingGround;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private Vector4 gravity;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool isInitialVelocityAdded;
	}
}
