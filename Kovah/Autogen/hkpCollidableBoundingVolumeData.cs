namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	public partial class hkpCollidableBoundingVolumeData
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 0, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 0, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 0, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		private uint min;
		[HavokMember(EVersion.Havok_7_1_0_r1, 12, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 12, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 12, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		private byte expansionMin;
		[HavokMember(EVersion.Havok_7_1_0_r1, 15, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 15, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 15, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 15, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte expansionShift;
		[HavokMember(EVersion.Havok_7_1_0_r1, 16, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 16, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 16, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		private uint max;
		[HavokMember(EVersion.Havok_7_1_0_r1, 28, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 28, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 28, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 3, FlagValues.FLAGS_NONE)]
		private byte expansionMax;
		[HavokMember(EVersion.Havok_7_1_0_r1, 31, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 31, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 31, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 31, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private byte padding;
		[HavokMember(EVersion.Havok_7_1_0_r1, 32, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 32, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 32, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private ushort numChildShapeAabbs;
		[HavokMember(EVersion.Havok_7_1_0_r1, 34, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 34, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 34, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 34, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private ushort capacityChildShapeAabbs;
		[HavokMember(EVersion.Havok_7_1_0_r1, 36, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 36, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 36, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ childShapeAabbs;
		[HavokMember(EVersion.Havok_7_1_0_r1, 40, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 40, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 40, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ childShapeKeys;
	}
}
