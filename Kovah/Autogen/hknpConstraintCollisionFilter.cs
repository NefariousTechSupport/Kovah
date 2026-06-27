namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpConstraintCollisionFilter : hknpPairCollisionFilter
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ subscribedWorld;
	}
}
