namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCustomTestGeneratorSimpleTypes : hkbCustomTestGeneratorHiddenTypes
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 104, null, null, hkClassMember.Type.TYPE_INT64, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.ALIGN_8)]
		private long simpleTypeHkInt64;
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, hkClassMember.Type.TYPE_UINT64, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ulong simpleTypeHkUint64;
		[HavokMember(EVersion.hk_2014_1_0_r1, 120, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool simpleHiddenTypeCopyStart;
		[HavokMember(EVersion.hk_2014_1_0_r1, 121, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool simpleTypeBool;
		[HavokMember(EVersion.hk_2014_1_0_r1, 122, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool simpleTypeHkBool;
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, null, null, hkClassMember.Type.TYPE_CSTRING, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string? simpleTypeCString;
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string? simpleTypeHkStringPtr;
		[HavokMember(EVersion.hk_2014_1_0_r1, 132, null, null, hkClassMember.Type.TYPE_INT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private sbyte simpleTypeHkInt8;
		[HavokMember(EVersion.hk_2014_1_0_r1, 134, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short simpleTypeHkInt16;
		[HavokMember(EVersion.hk_2014_1_0_r1, 136, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int simpleTypeHkInt32;
		[HavokMember(EVersion.hk_2014_1_0_r1, 140, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte simpleTypeHkUint8;
		[HavokMember(EVersion.hk_2014_1_0_r1, 142, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort simpleTypeHkUint16;
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint simpleTypeHkUint32;
		[HavokMember(EVersion.hk_2014_1_0_r1, 148, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float simpleTypeHkReal;
		[HavokMember(EVersion.hk_2014_1_0_r1, 152, null, null, hkClassMember.Type.TYPE_INT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private sbyte simpleTypeHkInt8Default;
		[HavokMember(EVersion.hk_2014_1_0_r1, 154, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short simpleTypeHkInt16Default;
		[HavokMember(EVersion.hk_2014_1_0_r1, 156, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int simpleTypeHkInt32Default;
		[HavokMember(EVersion.hk_2014_1_0_r1, 160, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte simpleTypeHkUint8Default;
		[HavokMember(EVersion.hk_2014_1_0_r1, 162, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort simpleTypeHkUint16Default;
		[HavokMember(EVersion.hk_2014_1_0_r1, 164, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint simpleTypeHkUint32Default;
		[HavokMember(EVersion.hk_2014_1_0_r1, 168, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float simpleTypeHkRealDefault;
		[HavokMember(EVersion.hk_2014_1_0_r1, 172, null, null, hkClassMember.Type.TYPE_INT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private sbyte simpleTypeHkInt8Clamp;
		[HavokMember(EVersion.hk_2014_1_0_r1, 174, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short simpleTypeHkInt16Clamp;
		[HavokMember(EVersion.hk_2014_1_0_r1, 176, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int simpleTypeHkInt32Clamp;
		[HavokMember(EVersion.hk_2014_1_0_r1, 180, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte simpleTypeHkUint8Clamp;
		[HavokMember(EVersion.hk_2014_1_0_r1, 182, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort simpleTypeHkUint16Clamp;
		[HavokMember(EVersion.hk_2014_1_0_r1, 184, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint simpleTypeHkUint32Clamp;
		[HavokMember(EVersion.hk_2014_1_0_r1, 188, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float simpleTypeHkRealClamp;
		[HavokMember(EVersion.hk_2014_1_0_r1, 192, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool simpleHiddenTypeCopyEnd;
	}
}
