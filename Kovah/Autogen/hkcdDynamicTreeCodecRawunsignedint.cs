namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdDynamicTreeCodecRawunsignedint
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkAabb), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkAabb), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkAabb? aabb;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint parent;
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private uint children;
	}
}
