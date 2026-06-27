namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpBodyQualityLibrary : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ qualityModifiedSignal;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hknpBodyQuality), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 32, hkClassMember.FlagValues.ALIGN_16)]
		private hknpBodyQuality? qualities;
	}
}
