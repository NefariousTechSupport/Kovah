namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkAabbUint32
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 0, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.ALIGN_16)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.ALIGN_16)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.ALIGN_16)]
		private uint min;
		[HavokMember(EVersion.Havok_7_1_0_r1, 12, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		private byte expansionMin;
		[HavokMember(EVersion.Havok_7_1_0_r1, 15, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 15, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 15, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte expansionShift;
		[HavokMember(EVersion.Havok_7_1_0_r1, 16, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		private uint max;
		[HavokMember(EVersion.Havok_7_1_0_r1, 28, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		private byte expansionMax;
		[HavokMember(EVersion.Havok_7_1_0_r1, 31, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 31, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 31, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte shapeKeyByte;
	}
}
