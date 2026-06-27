namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbBalanceRadialSelectorGenerator : hkbRadialSelectorGenerator
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 132, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int xAxisMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 136, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int yAxisMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 140, typeof(hkbCheckBalanceModifier), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbCheckBalanceModifier? checkBalanceModifier;
	}
}
