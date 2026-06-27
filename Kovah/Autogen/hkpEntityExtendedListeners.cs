namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	public partial class hkpEntityExtendedListeners
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 0, typeof(hkpEntitySmallArraySerializeOverrideType), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 0, typeof(hkpEntitySmallArraySerializeOverrideType), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkpEntitySmallArraySerializeOverrideType), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 0, typeof(hkpEntitySmallArraySerializeOverrideType), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private hkpEntitySmallArraySerializeOverrideType? activationListeners;
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, typeof(hkpEntitySmallArraySerializeOverrideType), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 8, typeof(hkpEntitySmallArraySerializeOverrideType), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkpEntitySmallArraySerializeOverrideType), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 8, typeof(hkpEntitySmallArraySerializeOverrideType), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private hkpEntitySmallArraySerializeOverrideType? entityListeners;
	}
}
