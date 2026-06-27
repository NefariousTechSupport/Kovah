namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpStaticCompoundShape : hkpBvTreeShape
	{
		public enum Config
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 48)]
			NUM_BYTES_FOR_TREE,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private sbyte numBitsForChildShapeKey;
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private uint childShapeKeyMask;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, typeof(hkpStaticCompoundShapeInstance), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpStaticCompoundShapeInstance?[]? instances;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, Type.TYPE_ARRAY, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private ushort[]? instanceExtraInfos;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, typeof(hkpShapeKeyTable), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkpShapeKeyTable? disabledLargeShapeKeyTable;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, typeof(hkcdStaticTreeDefaultTreeStorage6), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.ALIGN_16)]
		private hkcdStaticTreeDefaultTreeStorage6? tree;
	}
}
