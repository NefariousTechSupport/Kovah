namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbGenerator : hkbNode
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, typeof(hkbGeneratorPartitionInfo), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, typeof(hkbGeneratorPartitionInfo), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private hkbGeneratorPartitionInfo? partitionInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 84, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 84, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ syncInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 88, null, null, hkClassMember.Type.TYPE_INT8, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 88, null, null, hkClassMember.Type.TYPE_INT8, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private sbyte pad;
	}
}
