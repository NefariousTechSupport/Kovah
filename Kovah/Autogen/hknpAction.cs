namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpAction : hkReferencedObject
	{
		public enum Result : int
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			RESULT_OK,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			RESULT_REMOVE,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_ULONG, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ulong userData;
	}
}
