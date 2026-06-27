namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpShapeMaterialStringPalette : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRINGPTR, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string?[]? materialNames;
	}
}
