namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpDynamicCompoundShape : hknpCompoundShape
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 140, typeof(hknpDynamicCompoundShapeData), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpDynamicCompoundShapeData? boundingVolumeData;
	}
}
