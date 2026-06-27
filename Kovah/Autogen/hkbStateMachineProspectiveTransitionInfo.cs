namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbStateMachineProspectiveTransitionInfo
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkbStateMachineTransitionInfoReference), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkbStateMachineTransitionInfoReference), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbStateMachineTransitionInfoReference? transitionInfoReference;
		[HavokMember(EVersion.hk_2012_1_0_r1, 6, typeof(hkbStateMachineTransitionInfoReference), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 6, typeof(hkbStateMachineTransitionInfoReference), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbStateMachineTransitionInfoReference? transitionInfoReferenceForTE;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int toStateId;
	}
}
