namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpCompositeShape : hknpShape
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, typeof(hknpSparseCompactMapunsignedshort), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpSparseCompactMapunsignedshort? edgeWeldingMap;
		[HavokMember(EVersion.hk_2014_1_0_r1, 68, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint shapeTagCodecInfo;
	}
}
