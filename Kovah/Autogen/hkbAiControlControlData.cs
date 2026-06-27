namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbAiControlControlData
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkbAiControlControlDataBlendable), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbAiControlControlDataBlendable? blendable;
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkbAiControlControlDataNonBlendable), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbAiControlControlDataNonBlendable? nonBlendable;
	}
}
