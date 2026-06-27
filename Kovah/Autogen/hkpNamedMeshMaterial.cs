namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpNamedMeshMaterial : hkpMeshMaterial
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? name;
	}
}
