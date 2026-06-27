namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpBvShape : hkpShape
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 16, typeof(hkpShape), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, typeof(hkpShape), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpShape? boundingVolumeShape;
		[HavokMember(EVersion.Havok_7_1_0_r1, 20, typeof(hkpSingleShapeContainer), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, typeof(hkpSingleShapeContainer), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpSingleShapeContainer? childShape;
	}
}
