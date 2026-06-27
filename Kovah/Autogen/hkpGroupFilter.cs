namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpGroupFilter : hkpCollisionFilter
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 48, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int nextFreeSystemGroup;
		[HavokMember(EVersion.Havok_7_1_0_r1, 52, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 32, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 32, FlagValues.FLAGS_NONE)]
		private uint collisionLookupTable;
		[HavokMember(EVersion.Havok_7_1_0_r1, 192, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 4, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 192, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 4, FlagValues.FLAGS_NONE)]
		private Vector4 pad256;
	}
}
