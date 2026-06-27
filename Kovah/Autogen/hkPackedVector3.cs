namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkPackedVector3
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.ALIGN_8)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.ALIGN_8)]
		private short values;
	}
}
