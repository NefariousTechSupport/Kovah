namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbPinBonesGenerator : hkbGenerator
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, typeof(hkbGenerator), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, typeof(hkbGenerator), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbGenerator? referenceFrameGenerator;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, typeof(hkbGenerator), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, typeof(hkbGenerator), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbGenerator? pinnedGenerator;
		[HavokMember(EVersion.hk_2012_1_0_r1, 100, typeof(hkbBoneIndexArray), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 100, typeof(hkbBoneIndexArray), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbBoneIndexArray? boneIndices;
		[HavokMember(EVersion.hk_2012_1_0_r1, 104, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 104, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float fraction;
	}
}
