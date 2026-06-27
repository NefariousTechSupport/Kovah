namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpCompoundShape : hknpCompositeShape
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, typeof(hkFreeListArrayhknpShapeInstancehkHandleshort32767hknpShapeInstanceIdDiscriminant8hknpShapeInstance), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.ALIGN_16)]
		private hkFreeListArrayhknpShapeInstancehkHandleshort32767hknpShapeInstanceIdDiscriminant8hknpShapeInstance? instances;
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, typeof(hkAabb), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkAabb? aabb;
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool isMutable;
		[HavokMember(EVersion.hk_2014_1_0_r1, 132, typeof(hknpShapeSignals), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private hknpShapeSignals? mutationSignals;
	}
}
