namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbFootIkModifierLeg
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_QSTRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_QSTRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Matrix3x4 originalAnkleTransformMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 kneeAxisLS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 footEndLS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, typeof(hkbEventProperty), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, typeof(hkbEventProperty), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbEventProperty? ungroundedEvent;
		[HavokMember(EVersion.hk_2012_1_0_r1, 88, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 88, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float footPlantedAnkleHeightMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float footRaisedAnkleHeightMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float maxAnkleHeightMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 100, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 100, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float minAnkleHeightMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 104, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 104, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float maxKneeAngleDegrees;
		[HavokMember(EVersion.hk_2012_1_0_r1, 108, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 108, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float minKneeAngleDegrees;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float verticalError;
		[HavokMember(EVersion.hk_2012_1_0_r1, 116, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 116, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short hipIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 118, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 118, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short kneeIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 120, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 120, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short ankleIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 122, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 122, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool hitSomething;
		[HavokMember(EVersion.hk_2012_1_0_r1, 123, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 123, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool isPlantedMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 124, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool isOriginalAnkleTransformMSSet;
	}
}
