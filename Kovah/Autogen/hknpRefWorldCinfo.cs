namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpRefWorldCinfo : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hknpWorldCinfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hknpWorldCinfo? info;
	}
}
