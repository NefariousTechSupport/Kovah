namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpListShape : hkpShapeCollection
	{
		public enum ListShapeFlags
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			ALL_FLAGS_CLEAR,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			DISABLE_SPU_CACHE_FOR_LIST_CHILD_INFO,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, typeof(hkpListShapeChildInfo), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpListShapeChildInfo?[]? childInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort flags;
		[HavokMember(EVersion.hk_2012_1_0_r1, 38, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort numDisabledChildren;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 aabbHalfExtents;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 aabbCenter;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 8, FlagValues.FLAGS_NONE)]
		private uint enabledChildren;
	}
}
