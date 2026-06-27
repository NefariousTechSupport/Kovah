namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbGenerator : hkbNode
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, typeof(hkbGeneratorPartitionInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, typeof(hkbGeneratorPartitionInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private hkbGeneratorPartitionInfo? partitionInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 84, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 84, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ syncInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 88, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 4, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 88, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 4, FlagValues.SERIALIZE_IGNORED)]
		private sbyte pad;
	}
}
