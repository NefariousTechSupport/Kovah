namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpCompoundShapeInternalsKeyMask : hknpCompoundShapeKeyMask
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, typeof(hknpCompoundShape), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.NOT_OWNED)]
		private hknpCompoundShape? shape;
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hknpShapeKeyMask), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? instanceMasks;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private uint[]? filter;
	}
}
