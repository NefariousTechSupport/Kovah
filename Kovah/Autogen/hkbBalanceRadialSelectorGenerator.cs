namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbBalanceRadialSelectorGenerator : hkbRadialSelectorGenerator
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 132, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int xAxisMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 136, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int yAxisMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 140, typeof(hkbCheckBalanceModifier), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCheckBalanceModifier? checkBalanceModifier;
	}
}
