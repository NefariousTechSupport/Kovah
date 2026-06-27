namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbToolNodeType
	{
		public enum NodeType
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			NODE_TYPE_UNKNOWN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			NODE_TYPE_STATE_MACHINE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			NODE_TYPE_CLIP,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			NODE_TYPE_BLEND,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			NODE_TYPE_MODIFIER,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			NODE_TYPE_GENERATOR,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 32)]
			NODE_TYPE_MODIFIER_GENERATOR,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 64)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 64)]
			NODE_TYPE_TRANSITION_EFFECT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 128)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 128)]
			NODE_TYPE_BEHAVIOR_FILE_REFERENCE,
			
		}
	}
}
