namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpBvCompressedMeshShape : hkpBvTreeShape
	{
		public enum PerPrimitiveDataMode : int
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			PER_PRIMITIVE_DATA_NONE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			PER_PRIMITIVE_DATA_8_BIT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			PER_PRIMITIVE_DATA_PALETTE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			PER_PRIMITIVE_DATA_STRING_PALETTE,
			
		}
		public enum PrimitiveType : int
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			PRIMITIVE_TYPE_BOX,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			PRIMITIVE_TYPE_HULL,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			PRIMITIVE_TYPE_SPHERE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			PRIMITIVE_TYPE_CAPSULE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			PRIMITIVE_TYPE_CYLINDER,
			
		}
		public enum Config : int
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 144)]
			NUM_BYTES_FOR_TREE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 255)]
			MAX_NUM_VERTICES_PER_HULL,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8388608)]
			MAX_NUM_PRIMITIVES,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float convexRadius;
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, typeof(hkpWeldingUtility.WeldingType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpWeldingUtility.WeldingType weldingType;
		[HavokMember(EVersion.hk_2012_1_0_r1, 29, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool hasPerPrimitiveCollisionFilterInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 30, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool hasPerPrimitiveUserData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint[]? collisionFilterInfoPalette;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint[]? userDataPalette;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRINGPTR, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string?[]? userStringPalette;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, typeof(hkpBvCompressedMeshShapeTree), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.ALIGN_16)]
		private hkpBvCompressedMeshShapeTree? tree;
	}
}
