namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpShapeKeyTableBlock
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 63, hkClassMember.FlagValues.ALIGN_16)]
		private uint slots;
		[HavokMember(EVersion.hk_2012_1_0_r1, 252, typeof(hkpShapeKeyTableBlock), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpShapeKeyTableBlock? next;
	}
}
