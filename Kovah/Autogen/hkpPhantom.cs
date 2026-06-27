namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	public partial class hkpPhantom : hkpWorldObject
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 140, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 136, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 136, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 136, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? overlapListeners;
		[HavokMember(EVersion.Havok_7_1_0_r1, 152, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 148, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 148, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 148, null, null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? phantomListeners;
	}
}
