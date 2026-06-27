namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbHoldFromBlendingTransitionEffect : hkbBlendingTransitionEffect
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 256, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 248, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ heldFromPose;
		[HavokMember(EVersion.hk_2012_1_0_r1, 260, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 252, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private int heldFromPoseSize;
		[HavokMember(EVersion.hk_2012_1_0_r1, 272, null, null, Type.TYPE_QSTRANSFORM, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 256, null, null, Type.TYPE_QSTRANSFORM, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private Matrix3x4 heldWorldFromModel;
		[HavokMember(EVersion.hk_2012_1_0_r1, 320, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 304, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ heldFromSkeleton;
	}
}
