namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpShapeKeyTableBlock
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 63, FlagValues.ALIGN_16)]
		private uint slots;
		[HavokMember(EVersion.hk_2012_1_0_r1, 252, typeof(hkpShapeKeyTableBlock), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpShapeKeyTableBlock? next;
	}
}
