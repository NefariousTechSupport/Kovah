namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpBreakableMultiMaterialInverseMapping : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkpBreakableMultiMaterialInverseMappingDescriptor), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpBreakableMultiMaterialInverseMappingDescriptor?[]? descriptors;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private uint[]? subShapeIds;
	}
}
