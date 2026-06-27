namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbCustomTestGeneratorStruck
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool hkBool;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? @string;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int @int;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private sbyte hkInt8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 14, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short hkInt16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int hkInt32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte hkUint8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 22, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort hkUint16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint hkUint32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float hkReal;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, typeof(hkbCustomTestGenerator.Modes), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkInt8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 34, null, typeof(hkbCustomTestGenerator.Modes), Type.TYPE_ENUM, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkInt16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, null, typeof(hkbCustomTestGenerator.Modes), Type.TYPE_ENUM, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkInt32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, typeof(hkbCustomTestGenerator.Modes), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkUint8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 42, null, typeof(hkbCustomTestGenerator.Modes), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkUint16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, typeof(hkbCustomTestGenerator.Modes), Type.TYPE_ENUM, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkUint32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, typeof(hkbCustomTestGenerator.StrangeFlags), Type.TYPE_FLAGS, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkInt8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 50, null, typeof(hkbCustomTestGenerator.StrangeFlags), Type.TYPE_FLAGS, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkInt16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, typeof(hkbCustomTestGenerator.StrangeFlags), Type.TYPE_FLAGS, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkInt32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, null, typeof(hkbCustomTestGenerator.StrangeFlags), Type.TYPE_FLAGS, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkUint8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 58, null, typeof(hkbCustomTestGenerator.StrangeFlags), Type.TYPE_FLAGS, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkUint16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 60, null, typeof(hkbCustomTestGenerator.StrangeFlags), Type.TYPE_FLAGS, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkUint32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, typeof(hkbGenerator), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbGenerator? generator1;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, typeof(hkbGenerator), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbGenerator? generator2;
		[HavokMember(EVersion.hk_2012_1_0_r1, 72, typeof(hkbModifier), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbModifier? modifier1;
		[HavokMember(EVersion.hk_2012_1_0_r1, 76, typeof(hkbModifier), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbModifier? modifier2;
	}
}
