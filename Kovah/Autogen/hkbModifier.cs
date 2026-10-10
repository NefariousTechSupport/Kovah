namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkbNode))]
	[HavokClass(EVersion.hk_2014_1_0_r1, typeof(hkbNode))]
	public partial class hkbModifier : hkbNode
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool enable;
		[HavokMember(EVersion.hk_2012_1_0_r1, 45, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 3, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 45, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 3, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private bool[] padModifier = new bool[3];
		public hkbModifier()
		{
		}
	}
}
