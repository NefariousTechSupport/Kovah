namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpBreakableMultiMaterial : hkpBreakableMaterial
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, typeof(hkpBreakableMaterial), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? subMaterials;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, typeof(hkpBreakableMultiMaterialInverseMapping), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpBreakableMultiMaterialInverseMapping? inverseMapping;
	}
}
