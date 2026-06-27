namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbFootIkDriverInfo : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkbFootIkDriverInfoLeg), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkbFootIkDriverInfoLeg), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbFootIkDriverInfoLeg?[]? legs;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float raycastDistanceUp;
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float raycastDistanceDown;
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float originalGroundHeightMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float verticalOffset;
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint collisionFilterInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float forwardAlignFraction;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float sidewaysAlignFraction;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float sidewaysSampleWidth;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 52, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool lockFeetWhenPlanted;
		[HavokMember(EVersion.hk_2012_1_0_r1, 53, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 53, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool useCharacterUpVector;
		[HavokMember(EVersion.hk_2012_1_0_r1, 54, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 54, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool isQuadrupedNarrow;
		[HavokMember(EVersion.hk_2014_1_0_r1, 55, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool keepSourceFootEndAboveGround;
	}
}
