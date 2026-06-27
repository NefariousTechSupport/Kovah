namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpTyremarkPoint
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 pointLeft;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 pointRight;
	}
}
