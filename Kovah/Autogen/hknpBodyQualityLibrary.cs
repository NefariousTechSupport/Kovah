namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpBodyQualityLibrary : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ qualityModifiedSignal;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hknpBodyQuality), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 32, FlagValues.ALIGN_16)]
		private hknpBodyQuality? qualities;
	}
}
