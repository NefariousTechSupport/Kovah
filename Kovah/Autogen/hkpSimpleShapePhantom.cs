namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpSimpleShapePhantom : hkpShapePhantom
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 352, typeof(hkpSimpleShapePhantomCollisionDetail), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 336, typeof(hkpSimpleShapePhantomCollisionDetail), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.SERIALIZE_IGNORED)]
		private hkpSimpleShapePhantomCollisionDetail?[]? collisionDetails;
		[HavokMember(EVersion.Havok_7_1_0_r1, 364, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 348, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool orderDirty;
	}
}
