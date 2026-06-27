namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpMaskedShape : hknpDecoratorShape
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, typeof(hknpShapeKeyMask), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpShapeKeyMask? mask;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, typeof(hknpMaskedShapeMaskWrapper), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hknpMaskedShapeMaskWrapper? maskWrapper;
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, typeof(hknpShapeSignals), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private hknpShapeSignals? mutationSignals;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int maskSize;
	}
}
