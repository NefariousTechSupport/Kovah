namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, null)]
	[HavokClass(EVersion.hk_2014_1_0_r1, null)]
	public partial class hkPackedVector3
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.ALIGN_8)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.ALIGN_8)]
		private short[] values = new short[4];
		public hkPackedVector3()
		{
		}
	}
}
