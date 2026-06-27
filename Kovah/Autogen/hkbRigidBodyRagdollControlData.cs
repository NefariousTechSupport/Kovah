namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbRigidBodyRagdollControlData
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkaKeyFrameHierarchyUtilityControlData), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.ALIGN_16)]
		private hkaKeyFrameHierarchyUtilityControlData? keyFrameHierarchyControlData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float durationToBlend;
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkbKeyFrameControlData), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.ALIGN_16)]
		private hkbKeyFrameControlData? keyFrameControlData;
	}
}
