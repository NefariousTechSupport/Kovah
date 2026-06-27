namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	public partial class hkxEnum : hkReferencedObject
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, typeof(hkxEnumItem), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkxEnumItem?[]? items;
	}
}
