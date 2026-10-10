namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, null)]
	[HavokClass(EVersion.hk_2014_1_0_r1, null)]
	public partial class hkFloat16Transform
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkFloat16), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 12, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkFloat16), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 12, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkFloat16?[] elements = new hkFloat16?[12];
		public hkFloat16Transform()
		{
		}
	}
}
