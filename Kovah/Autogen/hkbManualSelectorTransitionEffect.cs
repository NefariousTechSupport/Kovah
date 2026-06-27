namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbManualSelectorTransitionEffect : hkbTransitionEffect
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 108, typeof(hkbTransitionEffect), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? transitionEffects;
		[HavokMember(EVersion.hk_2014_1_0_r1, 120, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte selectedIndex;
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, typeof(hkbCustomIdSelector), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCustomIdSelector? indexSelector;
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private byte currentTransitionEffectIndex;
		[HavokMember(EVersion.hk_2014_1_0_r1, 132, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ currentTransitionEffect;
		[HavokMember(EVersion.hk_2014_1_0_r1, 136, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ parentStateMachine;
		[HavokMember(EVersion.hk_2014_1_0_r1, 140, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ referenceBehavior;
	}
}
