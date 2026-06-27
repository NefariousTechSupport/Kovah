namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkSimpleLocalFrame : hkLocalFrame
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 16, null, null, Type.TYPE_TRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_TRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_TRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Matrix4x4 /* transform */ transform;
		[HavokMember(EVersion.Havok_7_1_0_r1, 80, typeof(hkLocalFrame), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, typeof(hkLocalFrame), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, typeof(hkLocalFrame), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? children;
		[HavokMember(EVersion.Havok_7_1_0_r1, 92, typeof(hkLocalFrame), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.NOT_OWNED)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, typeof(hkLocalFrame), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.NOT_OWNED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, typeof(hkLocalFrame), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.NOT_OWNED)]
		private hkLocalFrame? parentFrame;
		[HavokMember(EVersion.Havok_7_1_0_r1, 96, typeof(hkLocalFrameGroup), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, typeof(hkLocalFrameGroup), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, typeof(hkLocalFrameGroup), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkLocalFrameGroup? group;
		[HavokMember(EVersion.Havok_7_1_0_r1, 100, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 100, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 100, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? name;
	}
}
