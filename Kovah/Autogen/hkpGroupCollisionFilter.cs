namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpGroupCollisionFilter : hkpCollisionFilter
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool noGroupCollisionEnabled;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 32, FlagValues.FLAGS_NONE)]
		private uint collisionGroups;
	}
}
