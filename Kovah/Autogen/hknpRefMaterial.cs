namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpRefMaterial : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hknpMaterial), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hknpMaterial? material;
	}
}
