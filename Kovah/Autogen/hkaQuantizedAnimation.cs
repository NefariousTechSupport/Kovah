namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkaQuantizedAnimation : hkaAnimation
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private byte[]? data;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 52, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint endian;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ skeleton;
	}
}
