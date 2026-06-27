namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbReachModifier : hkbModifier
	{
		public enum ReachMode : int
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
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkbReachModifierHand), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbReachModifierHand?[]? hands;
		[HavokMember(EVersion.hk_2012_1_0_r1, 60, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float newTargetGain;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float noTargetGain;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float targetGain;
		[HavokMember(EVersion.hk_2012_1_0_r1, 72, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float fadeOutDuration;
		[HavokMember(EVersion.hk_2012_1_0_r1, 76, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int raycastLayer;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint sensingPropertyKey;
		[HavokMember(EVersion.hk_2012_1_0_r1, 84, null, typeof(hkbReachModifier.ReachMode), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbReachModifier.ReachMode reachMode;
		[HavokMember(EVersion.hk_2012_1_0_r1, 85, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool ignoreMySystemGroup;
		[HavokMember(EVersion.hk_2012_1_0_r1, 88, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float extrapolate;
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? internalHandData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 104, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private float timeLapse;
	}
}
