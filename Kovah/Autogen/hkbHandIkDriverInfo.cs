namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbHandIkDriverInfo : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkbHandIkDriverInfoHand), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkbHandIkDriverInfoHand), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbHandIkDriverInfoHand?[]? hands;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, typeof(hkbBlendCurveUtils.BlendCurve), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, typeof(hkbBlendCurveUtils.BlendCurve), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbBlendCurveUtils.BlendCurve fadeInOutCurve;
	}
}
