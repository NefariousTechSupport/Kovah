namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkAabbHalf
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 6, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 8, FlagValues.FLAGS_NONE)]
		private ushort data;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private ushort extras;
	}
}
