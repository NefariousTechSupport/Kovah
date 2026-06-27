namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbAiControlControlDataNonBlendable
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool canControl;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 3, FlagValues.SERIALIZE_IGNORED)]
		private byte padding;
	}
}
