namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpStaticCompoundShapeInstance
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_QSTRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Matrix3x4 transform;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkpShape), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpShape? shape;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint filterInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint childFilterInfoMask;
		[HavokMember(EVersion.hk_2012_1_0_r1, 60, null, null, Type.TYPE_ULONG, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ulong userData;
	}
}
