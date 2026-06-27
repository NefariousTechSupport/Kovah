namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbTransitionEffect : hkbGenerator
	{
		public enum EventMode
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			EVENT_MODE_DEFAULT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			EVENT_MODE_PROCESS_ALL,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			EVENT_MODE_IGNORE_FROM_GENERATOR,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			EVENT_MODE_IGNORE_TO_GENERATOR,
			
		}
		public enum SelfTransitionMode
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			SELF_TRANSITION_MODE_CONTINUE_IF_CYCLIC_BLEND_IF_ACYCLIC,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			SELF_TRANSITION_MODE_CONTINUE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			SELF_TRANSITION_MODE_RESET,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			SELF_TRANSITION_MODE_BLEND,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, null, typeof(hkbTransitionEffect.SelfTransitionMode), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, null, typeof(hkbTransitionEffect.SelfTransitionMode), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbTransitionEffect.SelfTransitionMode selfTransitionMode;
		[HavokMember(EVersion.hk_2012_1_0_r1, 93, null, typeof(hkbTransitionEffect.EventMode), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 93, null, typeof(hkbTransitionEffect.EventMode), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbTransitionEffect.EventMode eventMode;
		[HavokMember(EVersion.hk_2012_1_0_r1, 94, null, null, Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 94, null, null, Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.SERIALIZE_IGNORED)]
		private sbyte defaultEventMode;
		[HavokMember(EVersion.hk_2012_1_0_r1, 95, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 4, FlagValues.SERIALIZE_IGNORED)]
		private sbyte pad;
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ patchedBindingInfo;
		[HavokMember(EVersion.hk_2014_1_0_r1, 100, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ fromGenerator;
		[HavokMember(EVersion.hk_2014_1_0_r1, 104, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ toGenerator;
	}
}
