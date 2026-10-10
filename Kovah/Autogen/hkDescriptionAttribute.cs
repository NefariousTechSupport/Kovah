namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, null)]
	[HavokClass(EVersion.hk_2014_1_0_r1, null)]
	public partial class hkDescriptionAttribute
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_CSTRING, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_CSTRING, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string? @string;
		public hkDescriptionAttribute()
		{
		}
	}
}
