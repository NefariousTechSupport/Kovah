namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpGenericConstraintData : hkpConstraintData
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, typeof(hkpBridgeAtoms), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpBridgeAtoms? atoms;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, typeof(hkpGenericConstraintDataScheme), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpGenericConstraintDataScheme? scheme;
	}
}
