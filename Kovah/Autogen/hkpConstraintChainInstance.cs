namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpConstraintChainInstance : hkpConstraintInstance
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, typeof(hkpEntity), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? chainedEntities;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, typeof(hkpConstraintChainInstanceAction), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpConstraintChainInstanceAction? action;
		[HavokMember(EVersion.hk_2012_1_0_r1, 72, null, null, Type.TYPE_ULONG, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ulong chainConnectedness;
	}
}
