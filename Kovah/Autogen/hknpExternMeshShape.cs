namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpExternMeshShape : hknpCompositeShape
	{
		public enum RebuildFlagsEnum
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			REBUILD_USE_DOUBLE_BUFFERING,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			REBUILD_REFIT_ONLY,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, typeof(hknpExternMeshShapeGeometry), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.ALIGN_16)]
		private hknpExternMeshShapeGeometry? geometry;
		[HavokMember(EVersion.hk_2014_1_0_r1, 84, typeof(hknpExternMeshShapeData), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpExternMeshShapeData? boundingVolumeData;
	}
}
