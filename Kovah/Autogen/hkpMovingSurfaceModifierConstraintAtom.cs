namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpMovingSurfaceModifierConstraintAtom : hkpModifierConstraintAtom
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 velocity;
	}
}
