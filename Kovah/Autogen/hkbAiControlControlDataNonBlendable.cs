namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbAiControlControlDataNonBlendable
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool canControl;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 3, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private byte padding;
	}
}
