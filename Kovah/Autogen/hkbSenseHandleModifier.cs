namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbSenseHandleModifier : hkbModifier
	{
		public enum SensingMode
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			SENSE_IN_NEARBY_RIGID_BODIES,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			SENSE_IN_RIGID_BODIES_OUTSIDE_THIS_CHARACTER,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			SENSE_IN_OTHER_CHARACTER_RIGID_BODIES,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			SENSE_IN_THIS_CHARACTER_RIGID_BODIES,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			SENSE_IN_GIVEN_CHARACTER_RIGID_BODIES,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			SENSE_IN_GIVEN_RIGID_BODY,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 6)]
			SENSE_IN_OTHER_CHARACTER_SKELETON,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 7)]
			SENSE_IN_THIS_CHARACTER_SKELETON,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			SENSE_IN_GIVEN_CHARACTER_SKELETON,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 9)]
			SENSE_IN_GIVEN_LOCAL_FRAME_GROUP,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkbHandle), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, typeof(hkbHandle), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private hkbHandle? handle;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 sensorLocalOffset;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, typeof(hkbSenseHandleModifierRange), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, typeof(hkbSenseHandleModifierRange), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbSenseHandleModifierRange?[]? ranges;
		[HavokMember(EVersion.hk_2012_1_0_r1, 108, typeof(hkbHandle), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 108, typeof(hkbHandle), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbHandle? handleOut;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, typeof(hkbHandle), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, typeof(hkbHandle), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbHandle? handleIn;
		[HavokMember(EVersion.hk_2012_1_0_r1, 116, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 116, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? localFrameName;
		[HavokMember(EVersion.hk_2012_1_0_r1, 120, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 120, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? sensorLocalFrameName;
		[HavokMember(EVersion.hk_2012_1_0_r1, 124, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float minDistance;
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float maxDistance;
		[HavokMember(EVersion.hk_2012_1_0_r1, 132, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 132, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float distanceOut;
		[HavokMember(EVersion.hk_2012_1_0_r1, 136, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 136, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint collisionFilterInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 140, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 140, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short sensorRagdollBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 142, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 142, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short sensorAnimationBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, null, typeof(hkbSenseHandleModifier.SensingMode), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, null, typeof(hkbSenseHandleModifier.SensingMode), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbSenseHandleModifier.SensingMode sensingMode;
		[HavokMember(EVersion.hk_2012_1_0_r1, 145, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 145, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool extrapolateSensorPosition;
		[HavokMember(EVersion.hk_2012_1_0_r1, 146, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 146, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool keepFirstSensedHandle;
		[HavokMember(EVersion.hk_2012_1_0_r1, 147, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 147, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool foundHandleOut;
		[HavokMember(EVersion.hk_2012_1_0_r1, 148, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 148, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private float timeSinceLastModify;
		[HavokMember(EVersion.hk_2012_1_0_r1, 152, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 152, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private int rangeIndexForEventToSendNextUpdate;
	}
}
