namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpConstraintChainInstanceAction : hkpAction
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, typeof(hkpConstraintChainInstance), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.NOT_OWNED)]
		private hkpConstraintChainInstance? constraintInstance;
	}
}
