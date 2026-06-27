namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkPackfileSectionHeader
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 0, null, null, Type.TYPE_CHAR, Type.TYPE_VOID, 19, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_CHAR, Type.TYPE_VOID, 19, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_CHAR, Type.TYPE_VOID, 19, FlagValues.FLAGS_NONE)]
		private char sectionTag;
		[HavokMember(EVersion.Havok_7_1_0_r1, 19, null, null, Type.TYPE_CHAR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 19, null, null, Type.TYPE_CHAR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 19, null, null, Type.TYPE_CHAR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private char nullByte;
		[HavokMember(EVersion.Havok_7_1_0_r1, 20, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int absoluteDataStart;
		[HavokMember(EVersion.Havok_7_1_0_r1, 24, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int localFixupsOffset;
		[HavokMember(EVersion.Havok_7_1_0_r1, 28, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int globalFixupsOffset;
		[HavokMember(EVersion.Havok_7_1_0_r1, 32, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int virtualFixupsOffset;
		[HavokMember(EVersion.Havok_7_1_0_r1, 36, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int exportsOffset;
		[HavokMember(EVersion.Havok_7_1_0_r1, 40, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int importsOffset;
		[HavokMember(EVersion.Havok_7_1_0_r1, 44, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int endOffset;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 4, FlagValues.FLAGS_NONE)]
		private int pad;
	}
}
