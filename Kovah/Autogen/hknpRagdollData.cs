namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpRagdollData : hknpPhysicsSystemData
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 84, typeof(hkaSkeleton), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkaSkeleton? skeleton;
		[HavokMember(EVersion.hk_2014_1_0_r1, 88, null, null, Type.TYPE_ARRAY, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private int[]? boneToBodyMap;
	}
}
