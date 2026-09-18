namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpCompressedMeshShapeInternalsKeyMask : hknpShapeKeyMask
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, typeof(hknpCompressedMeshShape), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.NOT_OWNED)]
		private hknpCompressedMeshShape? shape;
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint[]? filter;
	}
}
