namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpShapeVertexColorPalette : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private uint[]? leafShapeKeys;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, typeof(hknpShapeVertexColorPaletteTriangle), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpShapeVertexColorPaletteTriangle?[]? leafShapeVertexColors;
	}
}
