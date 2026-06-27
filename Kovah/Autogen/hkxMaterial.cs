namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkxMaterial : hkxAttributeHolder
	{
		public enum TextureType : int
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			TEX_UNKNOWN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			TEX_DIFFUSE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			TEX_REFLECTION,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			TEX_BUMP,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			TEX_NORMAL,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			TEX_DISPLACEMENT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 6)]
			TEX_SPECULAR,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 7)]
			TEX_SPECULARANDGLOSS,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			TEX_OPACITY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 9)]
			TEX_EMISSIVE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 10)]
			TEX_REFRACTION,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 11)]
			TEX_GLOSS,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 13)]
			TEX_NOTEXPORTED,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 12)]
			TEX_DOMINANTS,
			
		}
		public enum PropertyKey : int
		{
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			PROPERTY_MTL_TYPE_BLEND,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 256)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 256)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 256)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 256)]
			PROPERTY_MTL_UV_ID_STAGE0,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 257)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 257)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 257)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 257)]
			PROPERTY_MTL_UV_ID_STAGE1,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 258)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 258)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 258)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 258)]
			PROPERTY_MTL_UV_ID_STAGE2,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 259)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 259)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 259)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 259)]
			PROPERTY_MTL_UV_ID_STAGE3,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 260)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 260)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 260)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 260)]
			PROPERTY_MTL_UV_ID_STAGE4,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 261)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 261)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 261)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 261)]
			PROPERTY_MTL_UV_ID_STAGE5,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 262)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 262)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 262)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 262)]
			PROPERTY_MTL_UV_ID_STAGE6,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 263)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 263)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 263)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 263)]
			PROPERTY_MTL_UV_ID_STAGE7,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 264)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 264)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 264)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 264)]
			PROPERTY_MTL_UV_ID_STAGE8,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 265)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 265)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 265)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 265)]
			PROPERTY_MTL_UV_ID_STAGE9,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 266)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 266)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 266)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 266)]
			PROPERTY_MTL_UV_ID_STAGE10,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 267)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 267)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 267)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 267)]
			PROPERTY_MTL_UV_ID_STAGE11,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 268)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 268)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 268)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 268)]
			PROPERTY_MTL_UV_ID_STAGE12,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 269)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 269)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 269)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 269)]
			PROPERTY_MTL_UV_ID_STAGE13,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 270)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 270)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 270)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 270)]
			PROPERTY_MTL_UV_ID_STAGE14,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 271)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 271)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 271)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 271)]
			PROPERTY_MTL_UV_ID_STAGE15,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 272)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 272)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 272)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 272)]
			PROPERTY_MTL_UV_ID_STAGE_MAX,
			
		}
		public enum UVMappingAlgorithm : int
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			UVMA_SRT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			UVMA_TRS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			UVMA_3DSMAX_STYLE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			UVMA_MAYA_STYLE,
			
		}
		public enum Transparency : int
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			transp_none,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			transp_alpha,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			transp_additive,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			transp_colorkey,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 9)]
			transp_subtractive,
			
		}
		[HavokMember(EVersion.Havok_7_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 20, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string? name;
		[HavokMember(EVersion.Havok_7_1_0_r1, 24, typeof(hkxMaterialTextureStage), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 24, typeof(hkxMaterialTextureStage), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, typeof(hkxMaterialTextureStage), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 24, typeof(hkxMaterialTextureStage), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, typeof(hkxMaterialTextureStage), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkxMaterialTextureStage?[]? stages;
		[HavokMember(EVersion.Havok_7_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 48, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 diffuseColor;
		[HavokMember(EVersion.Havok_7_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 64, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 ambientColor;
		[HavokMember(EVersion.Havok_7_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 80, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 specularColor;
		[HavokMember(EVersion.Havok_7_1_0_r1, 96, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 96, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 96, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 emissiveColor;
		[HavokMember(EVersion.Havok_7_1_0_r1, 112, typeof(hkxMaterial), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 112, typeof(hkxMaterial), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, typeof(hkxMaterial), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 112, typeof(hkxMaterial), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, typeof(hkxMaterial), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? subMaterials;
		[HavokMember(EVersion.Havok_7_1_0_r1, 124, typeof(hkReferencedObject), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 124, typeof(hkReferencedObject), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 124, typeof(hkReferencedObject), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 124, typeof(hkReferencedObject), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, typeof(hkReferencedObject), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkReferencedObject? extraData;
		[HavokMember(EVersion.hk_2011_2_0_r1, 128, typeof(hkxMaterialProperty), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 164, typeof(hkxMaterialProperty), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 164, typeof(hkxMaterialProperty), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 168, typeof(hkxMaterialProperty), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkxMaterialProperty?[]? properties;
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 2, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 2, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 2, hkClassMember.FlagValues.FLAGS_NONE)]
		private float uvMapScale;
		[HavokMember(EVersion.hk_2012_1_0_r1, 136, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 2, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 136, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 2, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 136, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 2, hkClassMember.FlagValues.FLAGS_NONE)]
		private float uvMapOffset;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 144, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float uvMapRotation;
		[HavokMember(EVersion.hk_2012_1_0_r1, 148, null, typeof(hkxMaterial.UVMappingAlgorithm), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 148, null, typeof(hkxMaterial.UVMappingAlgorithm), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 148, null, typeof(hkxMaterial.UVMappingAlgorithm), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkxMaterial.UVMappingAlgorithm uvMapAlgorithm;
		[HavokMember(EVersion.hk_2012_1_0_r1, 152, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 152, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 152, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float specularMultiplier;
		[HavokMember(EVersion.hk_2012_1_0_r1, 156, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 156, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 156, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float specularExponent;
		[HavokMember(EVersion.hk_2012_1_0_r1, 160, null, typeof(hkxMaterial.Transparency), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 160, null, typeof(hkxMaterial.Transparency), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 160, null, typeof(hkxMaterial.Transparency), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkxMaterial.Transparency transparency;
		[HavokMember(EVersion.hk_2014_1_0_r1, 164, null, null, hkClassMember.Type.TYPE_ULONG, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ulong userData;
	}
}
