namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, null)]
	[HavokClass(EVersion.hk_2014_1_0_r1, null)]
	public partial class hkAabb16
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 3, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 3, hkClassMember.FlagValues.ALIGN_16)]
		private ushort[] min = new ushort[3];
		[HavokMember(EVersion.hk_2012_1_0_r1, 6, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 6, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort key;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 3, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 3, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort[] max = new ushort[3];
		[HavokMember(EVersion.hk_2012_1_0_r1, 14, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 14, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort key1;
		public hkAabb16()
		{
		}
	}
}
