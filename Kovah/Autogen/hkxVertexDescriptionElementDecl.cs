namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkxVertexDescriptionElementDecl
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 0, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 0, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 0, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint byteOffset;
		[HavokMember(EVersion.Havok_7_1_0_r1, 4, null, typeof(hkxVertexDescription.DataType), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 4, null, typeof(hkxVertexDescription.DataType), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, typeof(hkxVertexDescription.DataType), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 4, null, typeof(hkxVertexDescription.DataType), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, typeof(hkxVertexDescription.DataType), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private hkxVertexDescription.DataType type;
		[HavokMember(EVersion.Havok_7_1_0_r1, 6, null, typeof(hkxVertexDescription.DataUsage), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 6, null, typeof(hkxVertexDescription.DataUsage), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 6, null, typeof(hkxVertexDescription.DataUsage), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 6, null, typeof(hkxVertexDescription.DataUsage), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 6, null, typeof(hkxVertexDescription.DataUsage), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private hkxVertexDescription.DataUsage usage;
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 8, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 8, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint byteStride;
		[HavokMember(EVersion.hk_2011_2_0_r1, 12, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 12, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte numElements;
		[HavokMember(EVersion.hk_2013_1_0_r1, 14, null, typeof(hkxVertexDescription.DataHint), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private hkxVertexDescription.DataHint hint;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? channelID;
	}
}
