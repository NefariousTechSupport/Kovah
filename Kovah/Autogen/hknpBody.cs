namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpBody
	{
		public enum SpuFlagsEnum
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			FORCE_NARROW_PHASE_PPU,
			
		}
		public enum Flags
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			IS_STATIC,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			IS_DYNAMIC,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			IS_KEYFRAMED,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			IS_ACTIVE,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_TRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Matrix4x4 /* transform */ transform;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int flags;
		[HavokMember(EVersion.hk_2014_1_0_r1, 68, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint collisionFilterInfo;
		[HavokMember(EVersion.hk_2014_1_0_r1, 72, typeof(hknpShape), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpShape? shape;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, typeof(hkAabb16), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkAabb16? aabb;
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint id;
		[HavokMember(EVersion.hk_2014_1_0_r1, 100, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint nextAttachedBodyId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 104, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint motionId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 108, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint broadPhaseId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort materialId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 114, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte qualityId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 115, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte timAngle;
		[HavokMember(EVersion.hk_2014_1_0_r1, 116, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort maxTimDistance;
		[HavokMember(EVersion.hk_2014_1_0_r1, 118, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort maxContactDistance;
		[HavokMember(EVersion.hk_2014_1_0_r1, 120, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint indexIntoActiveListOrDeactivatedIslandId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, null, null, Type.TYPE_HALF, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Half radiusOfComCenteredBoundingSphere;
		[HavokMember(EVersion.hk_2014_1_0_r1, 126, null, typeof(hknpBody.SpuFlagsEnum), Type.TYPE_FLAGS, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hknpBody.SpuFlagsEnum spuFlags;
		[HavokMember(EVersion.hk_2014_1_0_r1, 127, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte shapeSizeDiv16;
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 4, FlagValues.FLAGS_NONE)]
		private short motionToBodyRotation;
		[HavokMember(EVersion.hk_2014_1_0_r1, 136, null, null, Type.TYPE_UINT64, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ulong userData;
	}
}
