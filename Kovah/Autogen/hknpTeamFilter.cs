namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpTeamFilter : hknpCollisionFilter
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 16, hkClassMember.FlagValues.ALIGN_16)]
		private uint collisionLookupTable;
	}
}
