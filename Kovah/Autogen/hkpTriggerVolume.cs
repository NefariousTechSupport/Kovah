namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpTriggerVolume : hkReferencedObject
	{
		public enum EventType
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			ENTERED_EVENT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			LEFT_EVENT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			ENTERED_AND_LEFT_EVENT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			TRIGGER_BODY_LEFT_EVENT,
			
		}
		public enum Operation
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			ADDED_OP,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			REMOVED_OP,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			CONTACT_OP,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			TOI_OP,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, typeof(hkpRigidBody), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? overlappingBodies;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, typeof(hkpTriggerVolumeEventInfo), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpTriggerVolumeEventInfo?[]? eventQueue;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, typeof(hkpRigidBody), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpRigidBody? triggerBody;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint sequenceNumber;
	}
}
