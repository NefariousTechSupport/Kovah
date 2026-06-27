namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	public partial class hkxEnumItem
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 0, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int value;
		[HavokMember(EVersion.Havok_7_1_0_r1, 4, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? name;
	}
}
