namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbHandIkModifier : hkbModifier
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkbHandIkModifierHand), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, typeof(hkbHandIkModifierHand), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbHandIkModifierHand?[]? hands;
		[HavokMember(EVersion.hk_2012_1_0_r1, 60, null, typeof(hkbBlendCurveUtils.BlendCurve), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 60, null, typeof(hkbBlendCurveUtils.BlendCurve), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbBlendCurveUtils.BlendCurve fadeInOutCurve;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? internalHandData;
	}
}
