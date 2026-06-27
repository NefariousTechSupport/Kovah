namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpSetLocalRotationsConstraintAtom : hkpConstraintAtom
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_ROTATION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_ROTATION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion /* rotation */ rotationA;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_ROTATION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_ROTATION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion /* rotation */ rotationB;
	}
}
