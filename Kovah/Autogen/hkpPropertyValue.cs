namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1, null)]
	[HavokClass(EVersion.hk_2011_2_0_r1, null)]
	[HavokClass(EVersion.hk_2012_1_0_r1, null)]
	public partial class hkpPropertyValue
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_UINT64, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 0, null, null, hkClassMember.Type.TYPE_UINT64, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_UINT64, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ulong data;
		public hkpPropertyValue()
		{
		}
	}
}
