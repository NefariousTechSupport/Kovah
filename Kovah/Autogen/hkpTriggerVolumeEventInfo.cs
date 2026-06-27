namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpTriggerVolumeEventInfo
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_UINT64, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ulong sortValue;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkpRigidBody), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpRigidBody? body;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, typeof(hkpTriggerVolume.Operation), Type.TYPE_ENUM, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private hkpTriggerVolume.Operation operation;
	}
}
