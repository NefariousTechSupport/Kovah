namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpSimpleContactConstraintDataInfo
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.ALIGN_16)]
		private ushort flags;
		[HavokMember(EVersion.hk_2012_1_0_r1, 2, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort biNormalAxis;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, hkClassMember.Type.TYPE_HALF, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Half rollingFrictionMultiplier;
		[HavokMember(EVersion.hk_2012_1_0_r1, 6, null, null, hkClassMember.Type.TYPE_HALF, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Half internalData1;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_HALF, hkClassMember.Type.TYPE_VOID, 2, hkClassMember.FlagValues.FLAGS_NONE)]
		private Half rhsRolling;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float contactRadius;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.FLAGS_NONE)]
		private float data;
	}
}
