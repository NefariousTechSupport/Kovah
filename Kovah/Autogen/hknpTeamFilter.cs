namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpTeamFilter : hknpCollisionFilter
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 16, FlagValues.ALIGN_16)]
		private uint collisionLookupTable;
	}
}
