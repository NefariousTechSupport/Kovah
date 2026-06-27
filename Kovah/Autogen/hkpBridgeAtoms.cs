namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpBridgeAtoms
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkpBridgeConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.ALIGN_16)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkpBridgeConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.ALIGN_16)]
		private hkpBridgeConstraintAtom? bridgeAtom;
	}
}
