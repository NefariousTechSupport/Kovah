namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpBridgeConstraintAtom : hkpConstraintAtom
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ buildJacobianFunc;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkpConstraintData), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.NOT_OWNED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkpConstraintData), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.NOT_OWNED)]
		private hkpConstraintData? constraintData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private byte padding;
	}
}
