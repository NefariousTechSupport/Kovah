namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbStateChooserWrapper : hkbCustomIdSelector
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkbStateChooser), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbStateChooser? wrappedChooser;
	}
}
