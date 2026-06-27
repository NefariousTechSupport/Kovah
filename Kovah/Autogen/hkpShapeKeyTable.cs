namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpShapeKeyTable
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkpShapeKeyTableBlock), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpShapeKeyTableBlock? lists;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint occupancyBitField;
	}
}
