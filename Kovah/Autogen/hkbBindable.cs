namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbBindable : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkbVariableBindingSet), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkbVariableBindingSet), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbVariableBindingSet? variableBindingSet;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? cachedBindables;
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool areBindablesCached;
		[HavokMember(EVersion.hk_2012_1_0_r1, 25, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 25, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool hasEnableChanged;
	}
}
