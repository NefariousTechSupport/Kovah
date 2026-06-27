namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkAabbHalf
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 6, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 8, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort data;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 2, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort extras;
	}
}
