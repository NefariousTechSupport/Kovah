namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkaBone
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 0, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 0, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 0, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? name;
		[HavokMember(EVersion.Havok_7_1_0_r1, 4, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 4, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 4, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool lockTranslation;
	}
}
