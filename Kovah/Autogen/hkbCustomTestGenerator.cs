namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCustomTestGenerator : hkbCustomTestGeneratorAnnotatedTypes
	{
		public enum Modes : int
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			MODE_ALA,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			MODE_DEPECHE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			MODE_FURIOUS,
			
		}
		[Flags]
		public enum StrangeFlags : int
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
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 hkVector4;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool hkBool;
		[HavokMember(EVersion.hk_2012_1_0_r1, 116, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string? @string;
		[HavokMember(EVersion.hk_2012_1_0_r1, 120, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int @int;
		[HavokMember(EVersion.hk_2012_1_0_r1, 124, null, null, hkClassMember.Type.TYPE_INT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private sbyte hkInt8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 126, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short hkInt16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int hkInt32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 132, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte hkUint8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 134, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort hkUint16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 136, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint hkUint32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 140, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float hkReal;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, null, null, hkClassMember.Type.TYPE_QUATERNION, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Quaternion hkQuaternion;
		[HavokMember(EVersion.hk_2012_1_0_r1, 160, typeof(hkpRigidBody), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpRigidBody? hkRigidBody;
		[HavokMember(EVersion.hk_2012_1_0_r1, 164, null, typeof(hkbCustomTestGenerator.Modes), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkInt8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 166, null, typeof(hkbCustomTestGenerator.Modes), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkInt16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 168, null, typeof(hkbCustomTestGenerator.Modes), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkInt32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 172, null, typeof(hkbCustomTestGenerator.Modes), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkUint8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 174, null, typeof(hkbCustomTestGenerator.Modes), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkUint16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 176, null, typeof(hkbCustomTestGenerator.Modes), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.Modes mode_hkUint32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 180, null, typeof(hkbCustomTestGenerator.StrangeFlags), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkInt8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 182, null, typeof(hkbCustomTestGenerator.StrangeFlags), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkInt16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 184, null, typeof(hkbCustomTestGenerator.StrangeFlags), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_INT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkInt32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 188, null, typeof(hkbCustomTestGenerator.StrangeFlags), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkUint8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 190, null, typeof(hkbCustomTestGenerator.StrangeFlags), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_UINT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkUint16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 192, null, typeof(hkbCustomTestGenerator.StrangeFlags), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_UINT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCustomTestGenerator.StrangeFlags flags_hkUint32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 196, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int myInt;
		[HavokMember(EVersion.hk_2012_1_0_r1, 200, typeof(hkbGenerator), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbGenerator? generator1;
		[HavokMember(EVersion.hk_2012_1_0_r1, 204, typeof(hkbGenerator), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbGenerator? generator2;
		[HavokMember(EVersion.hk_2012_1_0_r1, 208, typeof(hkbModifier), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbModifier? modifier1;
		[HavokMember(EVersion.hk_2012_1_0_r1, 212, typeof(hkbModifier), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbModifier? modifier2;
		[HavokMember(EVersion.hk_2012_1_0_r1, 216, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_BOOL, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool[]? array_hkBool;
		[HavokMember(EVersion.hk_2012_1_0_r1, 228, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int[]? array_int;
		[HavokMember(EVersion.hk_2012_1_0_r1, 240, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private sbyte[]? array_hkInt8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 252, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short[]? array_hkInt16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 264, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int[]? array_hkInt32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 276, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private sbyte[]? array_hkUint8;
		[HavokMember(EVersion.hk_2012_1_0_r1, 288, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short[]? array_hkUint16;
		[HavokMember(EVersion.hk_2012_1_0_r1, 300, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int[]? array_hkUint32;
		[HavokMember(EVersion.hk_2012_1_0_r1, 312, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_REAL, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float[]? array_hkReal;
		[HavokMember(EVersion.hk_2012_1_0_r1, 324, typeof(hkbGenerator), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? array_hkbGenerator;
		[HavokMember(EVersion.hk_2012_1_0_r1, 336, typeof(hkbModifier), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? array_hkbModifier;
		[HavokMember(EVersion.hk_2012_1_0_r1, 348, typeof(hkbCustomTestGeneratorStruck), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorStruck? Struck;
		[HavokMember(EVersion.hk_2012_1_0_r1, 428, typeof(hkbCustomTestGeneratorStruck), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorStruck?[]? array_Struck;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1269, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool protectedHiddenMember;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1270, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool privateHiddenMember;
	}
}
