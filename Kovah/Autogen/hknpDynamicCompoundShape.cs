namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpDynamicCompoundShape : hknpCompoundShape
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 140, typeof(hknpDynamicCompoundShapeData), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpDynamicCompoundShapeData? boundingVolumeData;
	}
}
