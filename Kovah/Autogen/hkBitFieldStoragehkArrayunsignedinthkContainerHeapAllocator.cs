namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkBitFieldStoragehkArrayunsignedinthkContainerHeapAllocator
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private uint[]? words;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int numBits;
	}
}
