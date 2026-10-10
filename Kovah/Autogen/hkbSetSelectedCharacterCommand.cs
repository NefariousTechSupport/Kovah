namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkReferencedObject))]
	[HavokClass(EVersion.hk_2014_1_0_r1, typeof(hkReferencedObject))]
	public partial class hkbSetSelectedCharacterCommand : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_UINT64, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_UINT64, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ulong characterId;
		public hkbSetSelectedCharacterCommand()
		{
		}
	}
}
