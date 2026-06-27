namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpMaskedShapeMaskWrapper : hknpShapeKeyMask
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ maskedShape;
	}
}
