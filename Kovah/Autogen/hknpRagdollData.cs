namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpRagdollData : hknpPhysicsSystemData
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 84, typeof(hkaSkeleton), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkaSkeleton? skeleton;
		[HavokMember(EVersion.hk_2014_1_0_r1, 88, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int[]? boneToBodyMap;
	}
}
