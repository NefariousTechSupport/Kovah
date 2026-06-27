namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbReachModifierHand
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 targetOrSensingPosition;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 targetBackHandNormal;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float sensingRadius;
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short boneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 38, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short handIkTrackIndex;
	}
}
