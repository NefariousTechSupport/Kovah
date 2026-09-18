namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbRadialSelectorGeneratorGeneratorPair
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkbRadialSelectorGeneratorGeneratorInfo), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 2, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkbRadialSelectorGeneratorGeneratorInfo), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 2, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbRadialSelectorGeneratorGeneratorInfo? generators;
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float minAngle;
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float maxAngle;
	}
}
