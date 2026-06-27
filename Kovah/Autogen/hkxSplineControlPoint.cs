namespace Kovah
{
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	public partial class hkxSplineControlPoint
	{
		[HavokMember(EVersion.hk_2013_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 position;
		[HavokMember(EVersion.hk_2013_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 tangentIn;
		[HavokMember(EVersion.hk_2013_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 tangentOut;
		[HavokMember(EVersion.hk_2013_1_0_r1, 48, null, typeof(hkxSpline.ControlType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkxSpline.ControlType inType;
		[HavokMember(EVersion.hk_2013_1_0_r1, 49, null, typeof(hkxSpline.ControlType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkxSpline.ControlType outType;
	}
}
