namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpLodShape : hknpCompositeShape
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 72, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int numLevelsOfDetail;
		[HavokMember(EVersion.hk_2014_1_0_r1, 76, typeof(hknpLodShapeLevelOfDetailInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 8, FlagValues.FLAGS_NONE)]
		private hknpLodShapeLevelOfDetailInfo? infos;
		[HavokMember(EVersion.hk_2014_1_0_r1, 140, typeof(hknpShape), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 8, FlagValues.FLAGS_NONE)]
		private hknpShape? shapes;
		[HavokMember(EVersion.hk_2014_1_0_r1, 172, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 8, FlagValues.FLAGS_NONE)]
		private uint shapesMemorySizes;
		[HavokMember(EVersion.hk_2014_1_0_r1, 204, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int indexCurrentShapeOnSpu;
		[HavokMember(EVersion.hk_2014_1_0_r1, 208, typeof(hknpShape), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpShape? currentShapePpuAddress;
		[HavokMember(EVersion.hk_2014_1_0_r1, 224, typeof(hkAabb), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkAabb? maximumAabb;
	}
}
