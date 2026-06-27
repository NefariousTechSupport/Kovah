namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpTriggerVolumeEventInfo
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_UINT64, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ulong sortValue;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkpRigidBody), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpRigidBody? body;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, typeof(hkpTriggerVolume.Operation), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpTriggerVolume.Operation operation;
	}
}
