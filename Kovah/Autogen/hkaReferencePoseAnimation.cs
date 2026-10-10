namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkaAnimation))]
	[HavokClass(EVersion.hk_2014_1_0_r1, typeof(hkaAnimation))]
	public partial class hkaReferencePoseAnimation : hkaAnimation
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, typeof(hkaSkeleton), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, typeof(hkaSkeleton), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkaSkeleton? skeleton;
		public hkaReferencePoseAnimation()
		{
		}
	}
}
