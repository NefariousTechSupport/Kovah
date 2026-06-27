namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbReachModifier : hkbModifier
	{
		public enum ReachMode
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			REACH_MODE_TERRAIN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			REACH_MODE_WORLD_POSITION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			REACH_MODE_MODEL_POSITION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			REACH_MODE_BONE_POSITION,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkbReachModifierHand), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbReachModifierHand?[]? hands;
		[HavokMember(EVersion.hk_2012_1_0_r1, 60, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float newTargetGain;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float noTargetGain;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float targetGain;
		[HavokMember(EVersion.hk_2012_1_0_r1, 72, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float fadeOutDuration;
		[HavokMember(EVersion.hk_2012_1_0_r1, 76, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int raycastLayer;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint sensingPropertyKey;
		[HavokMember(EVersion.hk_2012_1_0_r1, 84, null, typeof(hkbReachModifier.ReachMode), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbReachModifier.ReachMode reachMode;
		[HavokMember(EVersion.hk_2012_1_0_r1, 85, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool ignoreMySystemGroup;
		[HavokMember(EVersion.hk_2012_1_0_r1, 88, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float extrapolate;
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? internalHandData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 104, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private float timeLapse;
	}
}
