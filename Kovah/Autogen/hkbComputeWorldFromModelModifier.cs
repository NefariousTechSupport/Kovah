namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbComputeWorldFromModelModifier : hkbModifier
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short poseMatchingRootBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 50, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 50, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short poseMatchingOtherBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 52, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short poseMatchingAnotherBoneIndex;
	}
}
