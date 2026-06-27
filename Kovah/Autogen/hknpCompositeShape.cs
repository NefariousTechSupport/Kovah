namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpCompositeShape : hknpShape
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, typeof(hknpSparseCompactMapunsignedshort), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hknpSparseCompactMapunsignedshort? edgeWeldingMap;
		[HavokMember(EVersion.hk_2014_1_0_r1, 68, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint shapeTagCodecInfo;
	}
}
