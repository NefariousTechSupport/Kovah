namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	public partial class hkpCollidable : hkpCdBody
	{
		public enum ForceCollideOntoPpuReasons
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			FORCE_PPU_USER_REQUEST,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			FORCE_PPU_SHAPE_REQUEST,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 4)]
			FORCE_PPU_MODIFIER_REQUEST,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 8)]
			FORCE_PPU_SHAPE_UNCHECKED,
			
		}
		[HavokMember(EVersion.Havok_7_1_0_r1, 16, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 16, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 16, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private sbyte ownerOffset;
		[HavokMember(EVersion.Havok_7_1_0_r1, 17, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 17, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 17, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 17, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte forceCollideOntoPpu;
		[HavokMember(EVersion.Havok_7_1_0_r1, 18, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 18, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 18, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 18, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private ushort shapeSizeOnSpu;
		[HavokMember(EVersion.Havok_7_1_0_r1, 20, typeof(hkpTypedBroadPhaseHandle), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 20, typeof(hkpTypedBroadPhaseHandle), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, typeof(hkpTypedBroadPhaseHandle), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 20, typeof(hkpTypedBroadPhaseHandle), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpTypedBroadPhaseHandle? broadPhaseHandle;
		[HavokMember(EVersion.Havok_7_1_0_r1, 32, typeof(hkpCollidableBoundingVolumeData), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 32, typeof(hkpCollidableBoundingVolumeData), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, typeof(hkpCollidableBoundingVolumeData), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 32, typeof(hkpCollidableBoundingVolumeData), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private hkpCollidableBoundingVolumeData? boundingVolumeData;
		[HavokMember(EVersion.Havok_7_1_0_r1, 76, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 76, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 76, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 76, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float allowedPenetrationDepth;
	}
}
