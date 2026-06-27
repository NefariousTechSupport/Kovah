namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpConstraintChainInstanceAction : hkpAction
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, typeof(hkpConstraintChainInstance), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.NOT_OWNED)]
		private hkpConstraintChainInstance? constraintInstance;
	}
}
