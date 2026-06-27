namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbTargetRigidBodyModifier : hkbModifier
	{
		public enum TargetMode
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			TARGET_MODE_CONE_AROUND_CHARACTER_FORWARD,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			TARGET_MODE_CONE_AROUND_LOCAL_AXIS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			TARGET_MODE_RAYCAST_ALONG_CHARACTER_FORWARD,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			TARGET_MODE_RAYCAST_ALONG_LOCAL_AXIS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			TARGET_MODE_ANY_DIRECTION,
			
		}
		public enum ComputeTargetAngleMode
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			COMPUTE_ANGLE_USING_TARGET_COM,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			COMPUTE_ANGLE_USING_TARGET_CONTACT_POINT,
			
		}
		public enum ComputeTargetDistanceMode
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			COMPUTE_DISTANCE_USING_TARGET_POSITION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			COMPUTE_DISTANCE_USING_TARGET_CONTACT_POINT,
			
		}
		public enum EventModeTRBAM
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			EVENT_MODE_DO_NOT_SEND,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			EVENT_MODE_SEND_ONCE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			EVENT_MODE_RESEND,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkbTarget), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbTarget? targetOut;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, typeof(hkbTargetRigidBodyModifier.TargetMode), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbTargetRigidBodyModifier.TargetMode targetMode;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int sensingLayer;
		[HavokMember(EVersion.hk_2012_1_0_r1, 60, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool targetOnlyOnce;
		[HavokMember(EVersion.hk_2012_1_0_r1, 61, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool ignoreMySystemGroup;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float maxTargetDistance;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float maxTargetHeightAboveSensor;
		[HavokMember(EVersion.hk_2012_1_0_r1, 72, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float closeToTargetDistanceThreshold;
		[HavokMember(EVersion.hk_2012_1_0_r1, 76, null, typeof(hkbTargetRigidBodyModifier.ComputeTargetAngleMode), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbTargetRigidBodyModifier.ComputeTargetAngleMode targetAngleMode;
		[HavokMember(EVersion.hk_2012_1_0_r1, 77, null, typeof(hkbTargetRigidBodyModifier.ComputeTargetDistanceMode), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbTargetRigidBodyModifier.ComputeTargetDistanceMode targetDistanceMode;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float maxAngleToTarget;
		[HavokMember(EVersion.hk_2012_1_0_r1, 84, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short sensorRagdollBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 86, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short sensorAnimationBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 88, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short closeToTargetRagdollBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 90, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short closeToTargetAnimationBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 sensorOffsetInBoneSpace;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 closeToTargetOffsetInBoneSpace;
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 sensorDirectionBS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, null, typeof(hkbTargetRigidBodyModifier.EventModeTRBAM), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbTargetRigidBodyModifier.EventModeTRBAM eventMode;
		[HavokMember(EVersion.hk_2012_1_0_r1, 148, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint sensingPropertyKey;
		[HavokMember(EVersion.hk_2012_1_0_r1, 152, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool sensorInWS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 156, typeof(hkbEventProperty), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbEventProperty? eventToSend;
		[HavokMember(EVersion.hk_2012_1_0_r1, 164, typeof(hkbEventProperty), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbEventProperty? eventToSendToTarget;
		[HavokMember(EVersion.hk_2012_1_0_r1, 172, typeof(hkbEventProperty), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbEventProperty? closeToTargetEvent;
		[HavokMember(EVersion.hk_2012_1_0_r1, 180, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool useVelocityPrediction;
		[HavokMember(EVersion.hk_2012_1_0_r1, 181, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool targetOnlySpheres;
		[HavokMember(EVersion.hk_2012_1_0_r1, 182, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool isCloseToTargetOut;
		[HavokMember(EVersion.hk_2012_1_0_r1, 183, null, null, hkClassMember.Type.TYPE_INT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private sbyte targetPriority;
		[HavokMember(EVersion.hk_2012_1_0_r1, 184, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ targetRb;
		[HavokMember(EVersion.hk_2012_1_0_r1, 188, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private float targetDistance;
		[HavokMember(EVersion.hk_2012_1_0_r1, 192, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private float timeSinceLastModify;
		[HavokMember(EVersion.hk_2012_1_0_r1, 196, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private bool eventHasBeenSent;
		[HavokMember(EVersion.hk_2012_1_0_r1, 197, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private bool closeToTargetEventHasBeenSent;
		[HavokMember(EVersion.hk_2012_1_0_r1, 198, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private bool isActive;
	}
}
