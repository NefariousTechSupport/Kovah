namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpLinearParametricCurve : hkpParametricCurve
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float smoothingFactor;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool closedLoop;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 dirNotParallelToTangentAlongWholePath;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_ARRAY, Type.TYPE_VECTOR4, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_ARRAY, Type.TYPE_VECTOR4, 0, FlagValues.FLAGS_NONE)]
		private Vector4[]? points;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, Type.TYPE_ARRAY, Type.TYPE_REAL, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, null, null, Type.TYPE_ARRAY, Type.TYPE_REAL, 0, FlagValues.FLAGS_NONE)]
		private float[]? distance;
	}
}
