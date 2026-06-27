namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbLayer : hkbBindable
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, typeof(hkbGenerator), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.ALIGN_16)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, typeof(hkbGenerator), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.ALIGN_16)]
		private hkbGenerator? generator;
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float weight;
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, typeof(hkbBoneWeightArray), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, typeof(hkbBoneWeightArray), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbBoneWeightArray? boneWeights;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float fadeInDuration;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float fadeOutDuration;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 52, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int onEventId;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int offEventId;
		[HavokMember(EVersion.hk_2012_1_0_r1, 60, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 60, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool onByDefault;
		[HavokMember(EVersion.hk_2012_1_0_r1, 61, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 61, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool useMotion;
		[HavokMember(EVersion.hk_2014_1_0_r1, 62, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool forceFullFadeDurations;
	}
}
