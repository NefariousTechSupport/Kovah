namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdShapeType
	{
		public enum ShapeTypeEnum
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			SPHERE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			CYLINDER,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			TRIANGLE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			BOX,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			CAPSULE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			CONVEX_VERTICES,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 6)]
			TRI_SAMPLED_HEIGHT_FIELD_COLLECTION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 7)]
			TRI_SAMPLED_HEIGHT_FIELD_BV_TREE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			LIST,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 9)]
			MOPP,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 10)]
			CONVEX_TRANSLATE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 11)]
			CONVEX_TRANSFORM,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 12)]
			SAMPLED_HEIGHT_FIELD,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 13)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 13)]
			EXTENDED_MESH,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 14)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 14)]
			TRANSFORM,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 15)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 15)]
			COMPRESSED_MESH,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			STATIC_COMPOUND,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 17)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 17)]
			BV_COMPRESSED_MESH,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 18)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 18)]
			COLLECTION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 19)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 19)]
			USER0,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 20)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 20)]
			USER1,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 21)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 21)]
			USER2,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 22)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 22)]
			BV_TREE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 23)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 23)]
			CONVEX,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 24)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 24)]
			CONVEX_PIECE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 25)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 25)]
			MULTI_SPHERE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 26)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 26)]
			CONVEX_LIST,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 27)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 27)]
			TRIANGLE_COLLECTION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 28)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 28)]
			HEIGHT_FIELD,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 29)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 29)]
			SPHERE_REP,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 30)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 30)]
			BV,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 31)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 31)]
			PLANE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 32)]
			PHANTOM_CALLBACK,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 33)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 33)]
			MULTI_RAY,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 34)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 34)]
			INVALID,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			FIRST_SHAPE_TYPE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 22)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 22)]
			MAX_SPU_SHAPE_TYPE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 35)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 35)]
			MAX_PPU_SHAPE_TYPE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, -1)]
			ALL_SHAPE_TYPES,
			
		}
	}
}
