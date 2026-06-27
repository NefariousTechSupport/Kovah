namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbStateMachineTransitionInfo
	{
		public enum TransitionFlags
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			FLAG_USE_TRIGGER_INTERVAL,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			FLAG_USE_INITIATE_INTERVAL,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			FLAG_UNINTERRUPTIBLE_WHILE_PLAYING,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			FLAG_UNINTERRUPTIBLE_WHILE_DELAYED,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			FLAG_DELAY_STATE_CHANGE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 32)]
			FLAG_DISABLED,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 64)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 64)]
			FLAG_DISALLOW_RETURN_TO_PREVIOUS_STATE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 128)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 128)]
			FLAG_DISALLOW_RANDOM_TRANSITION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 256)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 256)]
			FLAG_DISABLE_CONDITION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 512)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 512)]
			FLAG_ALLOW_SELF_TRANSITION_BY_TRANSITION_FROM_ANY_STATE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1024)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1024)]
			FLAG_IS_GLOBAL_WILDCARD,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2048)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2048)]
			FLAG_IS_LOCAL_WILDCARD,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4096)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4096)]
			FLAG_FROM_NESTED_STATE_ID_IS_VALID,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8192)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8192)]
			FLAG_TO_NESTED_STATE_ID_IS_VALID,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 16384)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16384)]
			FLAG_ABUT_AT_END_OF_FROM_GENERATOR,
			
		}
		public enum InternalFlagBits
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			FLAG_INTERNAL_IN_TRIGGER_INTERVAL,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			FLAG_INTERNAL_IN_INITIATE_INTERVAL,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkbStateMachineTimeInterval), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkbStateMachineTimeInterval), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbStateMachineTimeInterval? triggerInterval;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, typeof(hkbStateMachineTimeInterval), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hkbStateMachineTimeInterval), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbStateMachineTimeInterval? initiateInterval;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, typeof(hkbTransitionEffect), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, typeof(hkbTransitionEffect), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbTransitionEffect? transition;
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, typeof(hkbCondition), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, typeof(hkbCondition), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbCondition? condition;
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int eventId;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int toStateId;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int fromNestedStateId;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 52, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int toNestedStateId;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short priority;
		[HavokMember(EVersion.hk_2012_1_0_r1, 58, null, typeof(hkbStateMachineTransitionInfo.TransitionFlags), Type.TYPE_FLAGS, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 58, null, typeof(hkbStateMachineTransitionInfo.TransitionFlags), Type.TYPE_FLAGS, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		private hkbStateMachineTransitionInfo.TransitionFlags flags;
	}
}
