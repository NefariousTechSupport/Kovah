namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpPoweredChainData : hkpConstraintChainData
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, typeof(hkpBridgeAtoms), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpBridgeAtoms? atoms;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, typeof(hkpPoweredChainDataConstraintInfo), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpPoweredChainDataConstraintInfo?[]? infos;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float tau;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float damping;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float cfmLinAdd;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float cfmLinMul;
		[HavokMember(EVersion.hk_2012_1_0_r1, 60, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float cfmAngAdd;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float cfmAngMul;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float maxErrorDistance;
	}
}
