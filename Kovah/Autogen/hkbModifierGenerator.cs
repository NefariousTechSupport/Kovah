namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkbGenerator))]
	[HavokClass(EVersion.hk_2014_1_0_r1, typeof(hkbGenerator))]
	public partial class hkbModifierGenerator : hkbGenerator
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, typeof(hkbModifier), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, typeof(hkbModifier), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbModifier? modifier;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, typeof(hkbGenerator), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, typeof(hkbGenerator), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbGenerator? generator;
		public hkbModifierGenerator()
		{
		}
	}
}
