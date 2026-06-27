namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpBridgeConstraintAtom : hkpConstraintAtom
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int numSolverResults;
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkpConstraintData), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.NOT_OWNED)]
		private hkpConstraintData? constraintData;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 4, FlagValues.SERIALIZE_IGNORED)]
		private byte padding;
	}
}
