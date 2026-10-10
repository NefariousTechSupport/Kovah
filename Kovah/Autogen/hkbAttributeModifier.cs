namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkbModifier))]
	[HavokClass(EVersion.hk_2014_1_0_r1, typeof(hkbModifier))]
	public partial class hkbAttributeModifier : hkbModifier
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkbAttributeModifierAssignment), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, typeof(hkbAttributeModifierAssignment), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbAttributeModifierAssignment?[]? assignments;
		public hkbAttributeModifier()
		{
		}
	}
}
