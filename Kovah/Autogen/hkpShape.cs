namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	public partial class hkpShape : hkpShapeBase
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_ULONG, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 8, null, null, hkClassMember.Type.TYPE_ULONG, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_ULONG, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_ULONG, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ulong userData;
		[HavokMember(EVersion.Havok_7_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT32, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 12, null, null, hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT32, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private uint type;
	}
}
