namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpGenericConstraintDataSchemeConstraintInfo
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int maxSizeOfSchema;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int sizeOfSchemas;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int numSolverResults;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int numSolverElemTemps;
	}
}
