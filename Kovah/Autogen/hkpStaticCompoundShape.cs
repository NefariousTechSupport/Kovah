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
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, null, null, hkClassMember.Type.TYPE_INT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private sbyte numBitsForChildShapeKey;
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private uint childShapeKeyMask;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, typeof(hkpStaticCompoundShapeInstance), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpStaticCompoundShapeInstance?[]? instances;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort[]? instanceExtraInfos;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, typeof(hkpShapeKeyTable), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpShapeKeyTable? disabledLargeShapeKeyTable;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, typeof(hkcdStaticTreeDefaultTreeStorage6), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.ALIGN_16)]
		private hkcdStaticTreeDefaultTreeStorage6? tree;
	}
}
