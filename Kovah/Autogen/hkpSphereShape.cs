namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpSphereShape : hkpConvexShape
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 20, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.SERIALIZE_IGNORED)]
		private uint pad16;
	}
}
