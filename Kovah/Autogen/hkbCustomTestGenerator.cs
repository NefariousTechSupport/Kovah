namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCustomTestGenerator : hkbCustomTestGeneratorAnnotatedTypes
	{
		public enum Modes
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			MODE_ALA,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			MODE_DEPECHE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			MODE_FURIOUS,
			
		}
		public enum StrangeFlags
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			FLAG_UNO,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			FLAG_ZWEI,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			FLAG_SHI_OR_YON,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 240)]
			FLAG_LOTS_O_BITS,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 hkVector4;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool hkBool;
		[HavokMember(EVersion.hk_2012_1_0_r1, 116, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? @string;
		[HavokMember(EVersion.hk_2012_1_0_r1, 120, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int @int;
		[HavokMember(EVersion.hk_2012_1_0_r1, 124, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private sbyte hkInt8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 126, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short hkInt16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int hkInt32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 132, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte hkUint8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 134, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort hkUint16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 136, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint hkUint32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 140, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float hkReal;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion hkQuaternion;
		[HavokMember(EVersion.hk_2012_1_0_r1, 160, typeof(hkpRigidBody), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpRigidBody? hkRigidBody;
		[HavokMember(EVersion.hk_2012_1_0_r1, 164, null, typeof(hkbCustomTestGenerator.Modes), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkInt8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 166, null, typeof(hkbCustomTestGenerator.Modes), Type.TYPE_ENUM, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkInt16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 168, null, typeof(hkbCustomTestGenerator.Modes), Type.TYPE_ENUM, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkInt32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 172, null, typeof(hkbCustomTestGenerator.Modes), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkUint8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 174, null, typeof(hkbCustomTestGenerator.Modes), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkUint16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 176, null, typeof(hkbCustomTestGenerator.Modes), Type.TYPE_ENUM, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkUint32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 180, null, typeof(hkbCustomTestGenerator.StrangeFlags), Type.TYPE_FLAGS, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkInt8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 182, null, typeof(hkbCustomTestGenerator.StrangeFlags), Type.TYPE_FLAGS, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkInt16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 184, null, typeof(hkbCustomTestGenerator.StrangeFlags), Type.TYPE_FLAGS, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkInt32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 188, null, typeof(hkbCustomTestGenerator.StrangeFlags), Type.TYPE_FLAGS, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkUint8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 190, null, typeof(hkbCustomTestGenerator.StrangeFlags), Type.TYPE_FLAGS, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkUint16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 192, null, typeof(hkbCustomTestGenerator.StrangeFlags), Type.TYPE_FLAGS, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkUint32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 196, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int myInt;
		[HavokMember(EVersion.hk_2012_1_0_r1, 200, typeof(hkbGenerator), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbGenerator? generator1;
		[HavokMember(EVersion.hk_2012_1_0_r1, 204, typeof(hkbGenerator), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbGenerator? generator2;
		[HavokMember(EVersion.hk_2012_1_0_r1, 208, typeof(hkbModifier), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbModifier? modifier1;
		[HavokMember(EVersion.hk_2012_1_0_r1, 212, typeof(hkbModifier), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbModifier? modifier2;
		[HavokMember(EVersion.hk_2012_1_0_r1, 216, null, null, Type.TYPE_ARRAY, Type.TYPE_BOOL, 0, FlagValues.FLAGS_NONE)]
		private bool[]? array_hkBool;
		[HavokMember(EVersion.hk_2012_1_0_r1, 228, null, null, Type.TYPE_ARRAY, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private int[]? array_int;
		[HavokMember(EVersion.hk_2012_1_0_r1, 240, null, null, Type.TYPE_ARRAY, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private sbyte[]? array_hkInt8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 252, null, null, Type.TYPE_ARRAY, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		private short[]? array_hkInt16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 264, null, null, Type.TYPE_ARRAY, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private int[]? array_hkInt32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 276, null, null, Type.TYPE_ARRAY, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private sbyte[]? array_hkUint8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 288, null, null, Type.TYPE_ARRAY, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		private short[]? array_hkUint16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 300, null, null, Type.TYPE_ARRAY, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private int[]? array_hkUint32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 312, null, null, Type.TYPE_ARRAY, Type.TYPE_REAL, 0, FlagValues.FLAGS_NONE)]
		private float[]? array_hkReal;
		[HavokMember(EVersion.hk_2012_1_0_r1, 324, typeof(hkbGenerator), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? array_hkbGenerator;
		[HavokMember(EVersion.hk_2012_1_0_r1, 336, typeof(hkbModifier), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? array_hkbModifier;
		[HavokMember(EVersion.hk_2012_1_0_r1, 348, typeof(hkbCustomTestGeneratorStruck), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorStruck? Struck;
		[HavokMember(EVersion.hk_2012_1_0_r1, 428, typeof(hkbCustomTestGeneratorStruck), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorStruck?[]? array_Struck;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1269, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool protectedHiddenMember;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1270, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool privateHiddenMember;
	}
}
