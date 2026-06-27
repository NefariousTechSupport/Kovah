namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpRotationalConstraintDataAtoms
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkpSetLocalRotationsConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkpSetLocalRotationsConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpSetLocalRotationsConstraintAtom? rotations;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, typeof(hkpAngConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, typeof(hkpAngConstraintAtom), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpAngConstraintAtom? ang;
	}
}
