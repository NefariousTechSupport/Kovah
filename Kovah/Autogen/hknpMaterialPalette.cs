namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpMaterialPalette : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hknpMaterialDescriptor), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpMaterialDescriptor?[]? entries;
	}
}
