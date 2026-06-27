namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpArrayAction : hknpAction
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private uint[]? bodyIds;
	}
}
