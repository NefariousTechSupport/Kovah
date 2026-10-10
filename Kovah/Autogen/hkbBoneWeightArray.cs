namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkbBindable))]
	[HavokClass(EVersion.hk_2014_1_0_r1, typeof(hkbBindable))]
	public partial class hkbBoneWeightArray : hkbBindable
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_REAL, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_REAL, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float[]? boneWeights;
		public hkbBoneWeightArray()
		{
		}
	}
}
