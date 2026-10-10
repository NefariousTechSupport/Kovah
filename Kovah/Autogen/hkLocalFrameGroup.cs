namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1, typeof(hkReferencedObject))]
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkReferencedObject))]
	[HavokClass(EVersion.hk_2014_1_0_r1, typeof(hkReferencedObject))]
	public partial class hkLocalFrameGroup : hkReferencedObject
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string? name;
		public hkLocalFrameGroup()
		{
		}
	}
}
