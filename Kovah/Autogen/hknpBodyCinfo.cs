namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpBodyCinfo
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hknpShape), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.NOT_OWNED)]
		private hknpShape? shape;
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint reservedBodyId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint motionId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte qualityId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 14, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort materialId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint collisionFilterInfo;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int flags;
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float collisionLookAheadDistance;
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string? name;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_UINT64, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ulong userData;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 position;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_QUATERNION, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Quaternion orientation;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, typeof(hknpBody.SpuFlagsEnum), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpBody.SpuFlagsEnum spuFlags;
		[HavokMember(EVersion.hk_2014_1_0_r1, 84, typeof(hkLocalFrame), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkLocalFrame? localFrame;
	}
}
