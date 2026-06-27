namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpCompressedMeshShapeInternalsKeyMask : hknpShapeKeyMask
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, typeof(hknpCompressedMeshShape), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.NOT_OWNED)]
		private hknpCompressedMeshShape? shape;
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private uint[]? filter;
	}
}
