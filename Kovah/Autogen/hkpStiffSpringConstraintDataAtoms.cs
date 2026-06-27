namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpStiffSpringConstraintDataAtoms
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkpSetLocalTranslationsConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkpSetLocalTranslationsConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpSetLocalTranslationsConstraintAtom? pivots;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkpSetupStabilizationAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, typeof(hkpSetupStabilizationAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpSetupStabilizationAtom? setupStabilization;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, typeof(hkpStiffSpringConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, typeof(hkpStiffSpringConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpStiffSpringConstraintAtom? spring;
	}
}
