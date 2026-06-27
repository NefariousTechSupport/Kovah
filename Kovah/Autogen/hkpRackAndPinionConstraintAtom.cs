namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpRackAndPinionConstraintAtom : hkpConstraintAtom
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float pinionRadiusOrScrewPitch;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool isScrew;
		[HavokMember(EVersion.hk_2012_1_0_r1, 9, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 9, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private sbyte memOffsetToInitialAngleOffset;
		[HavokMember(EVersion.hk_2012_1_0_r1, 10, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 10, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private sbyte memOffsetToPrevAngle;
		[HavokMember(EVersion.hk_2012_1_0_r1, 11, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 11, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private sbyte memOffsetToRevolutionCounter;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 4, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 4, FlagValues.SERIALIZE_IGNORED)]
		private byte padding;
	}
}
