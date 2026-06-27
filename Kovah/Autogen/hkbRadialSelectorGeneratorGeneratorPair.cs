namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbRadialSelectorGeneratorGeneratorPair
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkbRadialSelectorGeneratorGeneratorInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkbRadialSelectorGeneratorGeneratorInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private hkbRadialSelectorGeneratorGeneratorInfo? generators;
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float minAngle;
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float maxAngle;
	}
}
