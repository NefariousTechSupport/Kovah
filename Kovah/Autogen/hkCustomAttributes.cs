namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkCustomAttributes
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 0, typeof(hkCustomAttributesAttribute), null, hkClassMember.Type.TYPE_SIMPLEARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkCustomAttributesAttribute), null, hkClassMember.Type.TYPE_SIMPLEARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 0, typeof(hkCustomAttributesAttribute), null, hkClassMember.Type.TYPE_SIMPLEARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkCustomAttributesAttribute), null, hkClassMember.Type.TYPE_SIMPLEARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkCustomAttributesAttribute?[]? attributes;
	}
}
