namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpListShapeChildInfo
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkpShape), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.ALIGN_16)]
		private hkpShape? shape;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint collisionFilterInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort shapeInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 10, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private short shapeSize;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private int numChildShapes;
	}
}
