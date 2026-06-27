namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbModifier : hkbNode
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool enable;
		[HavokMember(EVersion.hk_2012_1_0_r1, 45, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 3, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 45, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 3, FlagValues.SERIALIZE_IGNORED)]
		private bool padModifier;
	}
}
