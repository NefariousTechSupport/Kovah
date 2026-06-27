namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCustomTestGeneratorHiddenTypes : hkbReferencePoseGenerator
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool inheritedHiddenMember;
		[HavokMember(EVersion.hk_2014_1_0_r1, 97, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool protectedInheritedHiddenMember;
		[HavokMember(EVersion.hk_2014_1_0_r1, 98, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool privateInheritedHiddenMember;
	}
}
