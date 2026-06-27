namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkBitField : hkBitFieldBasehkBitFieldStoragehkArrayunsignedinthkContainerHeapAllocator
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 0, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private uint[]? words;
		[HavokMember(EVersion.Havok_7_1_0_r1, 12, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int numBits;
	}
}
