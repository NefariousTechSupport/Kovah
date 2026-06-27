namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpCachingShapePhantom : hkpShapePhantom
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 336, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? collisionDetails;
		[HavokMember(EVersion.hk_2012_1_0_r1, 348, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private bool orderDirty;
	}
}
