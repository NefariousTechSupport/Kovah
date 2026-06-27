namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpCogWheelConstraintAtom : hkpConstraintAtom
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float cogWheelRadiusA;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float cogWheelRadiusB;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool isScrew;
		[HavokMember(EVersion.hk_2012_1_0_r1, 13, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 13, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private sbyte memOffsetToInitialAngleOffset;
		[HavokMember(EVersion.hk_2012_1_0_r1, 14, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 14, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private sbyte memOffsetToPrevAngle;
		[HavokMember(EVersion.hk_2012_1_0_r1, 15, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 15, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private sbyte memOffsetToRevolutionCounter;
	}
}
