namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbFootIkControlsModifier : hkbModifier
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkbFootIkControlData), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, typeof(hkbFootIkControlData), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbFootIkControlData? controlData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, typeof(hkbFootIkControlsModifierLeg), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, typeof(hkbFootIkControlsModifierLeg), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbFootIkControlsModifierLeg?[]? legs;
	}
}
