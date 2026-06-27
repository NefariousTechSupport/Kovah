namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkxVertexDescription
	{
		public enum DataType
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			HKX_DT_NONE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			HKX_DT_UINT8,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			HKX_DT_INT16,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			HKX_DT_UINT32,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			HKX_DT_FLOAT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 5)]
			HKX_DT_FLOAT2,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 6)]
			HKX_DT_FLOAT3,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 7)]
			HKX_DT_FLOAT4,
			
		}
		public enum DataUsage
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			HKX_DU_NONE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			HKX_DU_POSITION,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			HKX_DU_COLOR,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			HKX_DU_NORMAL,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			HKX_DU_TANGENT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			HKX_DU_BINORMAL,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 32)]
			HKX_DU_TEXCOORD,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 64)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 64)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 64)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 64)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 64)]
			HKX_DU_BLENDWEIGHTS,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 128)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 128)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 128)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 128)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 128)]
			HKX_DU_BLENDINDICES,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 256)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 256)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 256)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 256)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 256)]
			HKX_DU_USERDATA,
			
		}
		public enum DataHint
		{
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			HKX_DH_NONE,
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			HKX_DH_LIGHTMAP,
			
		}
		[HavokMember(EVersion.Havok_7_1_0_r1, 0, typeof(hkxVertexDescriptionElementDecl), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 0, typeof(hkxVertexDescriptionElementDecl), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkxVertexDescriptionElementDecl), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 0, typeof(hkxVertexDescriptionElementDecl), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkxVertexDescriptionElementDecl), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkxVertexDescriptionElementDecl?[]? decls;
	}
}
