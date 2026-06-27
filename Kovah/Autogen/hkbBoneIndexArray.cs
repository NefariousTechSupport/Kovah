namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbBoneIndexArray : hkbBindable
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, Type.TYPE_ARRAY, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, Type.TYPE_ARRAY, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		private short[]? boneIndices;
	}
}
