namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpSimpleShapePhantom : hkpShapePhantom
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 352, typeof(hkpSimpleShapePhantomCollisionDetail), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 336, typeof(hkpSimpleShapePhantomCollisionDetail), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private hkpSimpleShapePhantomCollisionDetail?[]? collisionDetails;
		[HavokMember(EVersion.Havok_7_1_0_r1, 364, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 348, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private bool orderDirty;
	}
}
