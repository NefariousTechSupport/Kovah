namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCustomTestGeneratorBoneTypes : hkbCustomTestGeneratorNestedTypes
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 1100, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool boneHiddenTypeCopyStart;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1102, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short oldBoneIndex;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1104, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short oldBoneIndexNoVar;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1106, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short boneIndex;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1108, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short boneIndexNoVar;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1110, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short boneChainIndex0;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1112, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short boneChainIndex1;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1114, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short boneChainIndex2;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1116, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short boneContractIndex0;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1118, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short boneContractIndex1;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1120, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short boneContractIndex2;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1122, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool boneHiddenTypeCopyEnd;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1124, typeof(hkbBoneWeightArray), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbBoneWeightArray? boneWeightArray;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1128, typeof(hkbBoneIndexArray), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbBoneIndexArray? boneIndexArray;
	}
}
