namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpCompressedMeshShapeChunk
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 offset;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private ushort[]? vertices;
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private ushort[]? indices;
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private ushort[]? stripLengths;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private ushort[]? weldingInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint materialInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort reference;
		[HavokMember(EVersion.hk_2012_1_0_r1, 70, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort transformIndex;
	}
}
