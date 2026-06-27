namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpBreakableMultiMaterial : hkpBreakableMaterial
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, typeof(hkpBreakableMaterial), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? subMaterials;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, typeof(hkpBreakableMultiMaterialInverseMapping), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpBreakableMultiMaterialInverseMapping? inverseMapping;
	}
}
