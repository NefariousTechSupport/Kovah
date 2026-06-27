namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpSimpleContactConstraintDataInfo
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.ALIGN_16)]
		private ushort flags;
		[HavokMember(EVersion.hk_2012_1_0_r1, 2, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort biNormalAxis;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, Type.TYPE_HALF, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Half rollingFrictionMultiplier;
		[HavokMember(EVersion.hk_2012_1_0_r1, 6, null, null, Type.TYPE_HALF, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Half internalData1;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_HALF, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private Half rhsRolling;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float contactRadius;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 4, FlagValues.FLAGS_NONE)]
		private float data;
	}
}
