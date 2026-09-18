namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpStaticCompoundShape : hknpCompoundShape
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 140, typeof(hknpStaticCompoundShapeData), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpStaticCompoundShapeData? boundingVolumeData;
	}
}
