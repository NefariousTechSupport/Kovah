namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpCachingShapePhantom : hkpShapePhantom
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 336, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? collisionDetails;
		[HavokMember(EVersion.hk_2012_1_0_r1, 348, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool orderDirty;
	}
}
