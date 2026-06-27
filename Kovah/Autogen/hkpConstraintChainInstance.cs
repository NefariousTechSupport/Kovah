namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpConstraintChainInstance : hkpConstraintInstance
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, typeof(hkpEntity), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? chainedEntities;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, typeof(hkpConstraintChainInstanceAction), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpConstraintChainInstanceAction? action;
		[HavokMember(EVersion.hk_2012_1_0_r1, 72, null, null, hkClassMember.Type.TYPE_ULONG, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ulong chainConnectedness;
	}
}
