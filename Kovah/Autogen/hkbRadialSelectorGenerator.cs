namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbRadialSelectorGenerator : hkbGenerator
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, typeof(hkbRadialSelectorGeneratorGeneratorPair), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, typeof(hkbRadialSelectorGeneratorGeneratorPair), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbRadialSelectorGeneratorGeneratorPair?[]? generatorPairs;
		[HavokMember(EVersion.hk_2012_1_0_r1, 104, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 104, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float angle;
		[HavokMember(EVersion.hk_2012_1_0_r1, 108, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 108, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float radius;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private int currentGeneratorPairIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 116, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 116, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private int currentEndpointIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 120, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 120, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private float currentFraction;
		[HavokMember(EVersion.hk_2012_1_0_r1, 124, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private bool hasSetLocalTime;
		[HavokMember(EVersion.hk_2012_1_0_r1, 125, null, null, hkClassMember.Type.TYPE_INT8, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 125, null, null, hkClassMember.Type.TYPE_INT8, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private sbyte pad;
	}
}
