namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpMaskedShape : hknpDecoratorShape
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, typeof(hknpShapeKeyMask), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpShapeKeyMask? mask;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, typeof(hknpMaskedShapeMaskWrapper), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpMaskedShapeMaskWrapper? maskWrapper;
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, typeof(hknpShapeSignals), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private hknpShapeSignals? mutationSignals;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int maskSize;
	}
}
