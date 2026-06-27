namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCustomTestGeneratorComplexTypes : hkbCustomTestGeneratorSimpleTypes
	{
		public enum CustomEnum
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			CUSTOM_ENUM_ALA,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			CUSTOM_ENUM_DEPECHE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			CUSTOM_ENUM_FURIOUS,
			
		}
		public enum CustomFlag
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			CUSTOM_FLAG_NONE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			CUSTOM_FLAG_UNO,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			CUSTOM_FLAG_ZWEI,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			CUSTOM_FLAG_SHI_OR_YON,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 240)]
			CUSTOM_FLAG_LOTS_O_BITS,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 196, typeof(hkReferencedObject), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkReferencedObject? complexTypeHkObjectPtr;
		[HavokMember(EVersion.hk_2014_1_0_r1, 200, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool complexHiddenTypeCopyStart;
		[HavokMember(EVersion.hk_2014_1_0_r1, 208, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion complexTypeHkQuaternion;
		[HavokMember(EVersion.hk_2014_1_0_r1, 224, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 complexTypeHkVector4;
		[HavokMember(EVersion.hk_2014_1_0_r1, 240, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomEnum), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomEnum complexTypeEnumHkInt8;
		[HavokMember(EVersion.hk_2014_1_0_r1, 242, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomEnum), Type.TYPE_ENUM, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomEnum complexTypeEnumHkInt16;
		[HavokMember(EVersion.hk_2014_1_0_r1, 244, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomEnum), Type.TYPE_ENUM, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomEnum complexTypeEnumHkInt32;
		[HavokMember(EVersion.hk_2014_1_0_r1, 248, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomEnum), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomEnum complexTypeEnumHkUint8;
		[HavokMember(EVersion.hk_2014_1_0_r1, 250, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomEnum), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomEnum complexTypeEnumHkUint16;
		[HavokMember(EVersion.hk_2014_1_0_r1, 252, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomEnum), Type.TYPE_ENUM, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomEnum complexTypeEnumHkUint32;
		[HavokMember(EVersion.hk_2014_1_0_r1, 256, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomEnum), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomEnum complexTypeEnumHkInt8InvalidCheck;
		[HavokMember(EVersion.hk_2014_1_0_r1, 258, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomEnum), Type.TYPE_ENUM, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomEnum complexTypeEnumHkInt16InvalidCheck;
		[HavokMember(EVersion.hk_2014_1_0_r1, 260, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomEnum), Type.TYPE_ENUM, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomEnum complexTypeEnumHkInt32InvalidCheck;
		[HavokMember(EVersion.hk_2014_1_0_r1, 264, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomEnum), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomEnum complexTypeEnumHkUint8InvalidCheck;
		[HavokMember(EVersion.hk_2014_1_0_r1, 266, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomEnum), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomEnum complexTypeEnumHkUint16InvalidCheck;
		[HavokMember(EVersion.hk_2014_1_0_r1, 268, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomEnum), Type.TYPE_ENUM, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomEnum complexTypeEnumHkUint32InvalidCheck;
		[HavokMember(EVersion.hk_2014_1_0_r1, 272, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomFlag), Type.TYPE_FLAGS, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomFlag complexTypeFlagsHkInt8;
		[HavokMember(EVersion.hk_2014_1_0_r1, 274, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomFlag), Type.TYPE_FLAGS, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomFlag complexTypeFlagsHkInt16;
		[HavokMember(EVersion.hk_2014_1_0_r1, 276, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomFlag), Type.TYPE_FLAGS, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomFlag complexTypeFlagsHkInt32;
		[HavokMember(EVersion.hk_2014_1_0_r1, 280, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomFlag), Type.TYPE_FLAGS, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomFlag complexTypeFlagsHkUint8;
		[HavokMember(EVersion.hk_2014_1_0_r1, 282, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomFlag), Type.TYPE_FLAGS, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomFlag complexTypeFlagsHkUint16;
		[HavokMember(EVersion.hk_2014_1_0_r1, 284, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomFlag), Type.TYPE_FLAGS, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomFlag complexTypeFlagsHkUint32;
		[HavokMember(EVersion.hk_2014_1_0_r1, 288, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomFlag), Type.TYPE_FLAGS, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomFlag complexTypeFlagsHkInt8InvalidCheck;
		[HavokMember(EVersion.hk_2014_1_0_r1, 290, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomFlag), Type.TYPE_FLAGS, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomFlag complexTypeFlagsHkInt16InvalidCheck;
		[HavokMember(EVersion.hk_2014_1_0_r1, 292, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomFlag), Type.TYPE_FLAGS, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomFlag complexTypeFlagsHkInt32InvalidCheck;
		[HavokMember(EVersion.hk_2014_1_0_r1, 296, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomFlag), Type.TYPE_FLAGS, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomFlag complexTypeFlagsHkUint8InvalidCheck;
		[HavokMember(EVersion.hk_2014_1_0_r1, 298, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomFlag), Type.TYPE_FLAGS, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomFlag complexTypeFlagsHkUint16InvalidCheck;
		[HavokMember(EVersion.hk_2014_1_0_r1, 300, null, typeof(hkbCustomTestGeneratorComplexTypes.CustomFlag), Type.TYPE_FLAGS, Type.TYPE_UINT32, 0, FlagValues.FLAGS_NONE)]
		private hkbCustomTestGeneratorComplexTypes.CustomFlag complexTypeFlagsHkUint32InvalidCheck;
		[HavokMember(EVersion.hk_2014_1_0_r1, 304, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool complexHiddenTypeCopyEnd;
	}
}
