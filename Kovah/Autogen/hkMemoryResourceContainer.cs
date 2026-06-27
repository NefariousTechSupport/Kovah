namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkMemoryResourceContainer : hkResourceContainer
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 8, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string? name;
		[HavokMember(EVersion.Havok_7_1_0_r1, 12, typeof(hkMemoryResourceContainer), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 12, typeof(hkMemoryResourceContainer), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, typeof(hkMemoryResourceContainer), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 12, typeof(hkMemoryResourceContainer), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, typeof(hkMemoryResourceContainer), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private hkMemoryResourceContainer? parent;
		[HavokMember(EVersion.Havok_7_1_0_r1, 16, typeof(hkMemoryResourceHandle), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 16, typeof(hkMemoryResourceHandle), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, typeof(hkMemoryResourceHandle), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 16, typeof(hkMemoryResourceHandle), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hkMemoryResourceHandle), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? resourceHandles;
		[HavokMember(EVersion.Havok_7_1_0_r1, 28, typeof(hkMemoryResourceContainer), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 28, typeof(hkMemoryResourceContainer), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, typeof(hkMemoryResourceContainer), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 28, typeof(hkMemoryResourceContainer), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, typeof(hkMemoryResourceContainer), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? children;
	}
}
