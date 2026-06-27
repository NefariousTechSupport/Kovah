namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbManualSelectorGenerator : hkbGenerator
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, typeof(hkbGenerator), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, typeof(hkbGenerator), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? generators;
		[HavokMember(EVersion.hk_2012_1_0_r1, 104, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 104, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short selectedGeneratorIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 105, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool selectedIndexCanChangeAfterActivate;
		[HavokMember(EVersion.hk_2012_1_0_r1, 108, typeof(hkbTransitionEffect), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 116, typeof(hkbTransitionEffect), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbTransitionEffect? generatorChangedTransitionEffect;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 120, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private short currentGeneratorIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 113, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 122, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private short generatorIndexAtActivate;
		[HavokMember(EVersion.hk_2012_1_0_r1, 116, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? activeTransitions;
		[HavokMember(EVersion.hk_2014_1_0_r1, 108, typeof(hkbCustomIdSelector), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomIdSelector? indexSelector;
	}
}
