namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpPhysicsSystemWithContacts : hkpPhysicsSystem
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, typeof(hkpSerializedAgentNnEntry), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? contacts;
	}
}
