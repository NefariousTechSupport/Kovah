namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpShapeMassProperties : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkCompressedMassProperties), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.ALIGN_8)]
		private hkCompressedMassProperties? compressedMassProperties;
	}
}
