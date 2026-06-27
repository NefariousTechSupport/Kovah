namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCharacterData : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkbCharacterDataCharacterControllerInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbCharacterDataCharacterControllerInfo? characterControllerInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 modelUpMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 modelForwardMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 modelRightMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, typeof(hkbVariableInfo), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, typeof(hkbVariableInfo), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbVariableInfo?[]? characterPropertyInfos;
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, null, null, Type.TYPE_ARRAY, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 108, null, null, Type.TYPE_ARRAY, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private int[]? numBonesPerLod;
		[HavokMember(EVersion.hk_2012_1_0_r1, 104, typeof(hkbVariableValueSet), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 120, typeof(hkbVariableValueSet), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbVariableValueSet? characterPropertyValues;
		[HavokMember(EVersion.hk_2012_1_0_r1, 108, typeof(hkbFootIkDriverInfo), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, typeof(hkbFootIkDriverInfo), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbFootIkDriverInfo? footIkDriverInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, typeof(hkbHandIkDriverInfo), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, typeof(hkbHandIkDriverInfo), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbHandIkDriverInfo? handIkDriverInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 116, typeof(hkbCharacterStringData), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 136, typeof(hkbCharacterStringData), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbCharacterStringData? stringData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 120, typeof(hkbMirroredSkeletonInfo), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 140, typeof(hkbMirroredSkeletonInfo), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbMirroredSkeletonInfo? mirroredSkeletonInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 124, null, null, Type.TYPE_ARRAY, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, null, null, Type.TYPE_ARRAY, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		private short[]? boneAttachmentBoneIndices;
		[HavokMember(EVersion.hk_2012_1_0_r1, 136, null, null, Type.TYPE_ARRAY, Type.TYPE_MATRIX4, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 156, null, null, Type.TYPE_ARRAY, Type.TYPE_MATRIX4, 0, FlagValues.FLAGS_NONE)]
		private Matrix4x4[]? boneAttachmentTransforms;
		[HavokMember(EVersion.hk_2012_1_0_r1, 148, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 168, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float scale;
		[HavokMember(EVersion.hk_2012_1_0_r1, 152, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 172, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private short numHands;
		[HavokMember(EVersion.hk_2012_1_0_r1, 154, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 174, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private short numFloatSlots;
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkbCharacterControllerSetup), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbCharacterControllerSetup? characterControllerSetup;
		[HavokMember(EVersion.hk_2014_1_0_r1, 132, typeof(hkReferencedObject), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkReferencedObject? aiControlDriverInfo;
	}
}
