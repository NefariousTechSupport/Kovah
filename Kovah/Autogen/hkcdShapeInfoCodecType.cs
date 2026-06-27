namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdShapeInfoCodecType
	{
		public enum ShapeInfoCodecTypeEnum
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			NULL_CODEC,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			UFM358,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			MAX_NUM_CODECS,
			
		}
	}
}
