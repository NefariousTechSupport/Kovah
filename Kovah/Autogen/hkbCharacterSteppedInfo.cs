namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCharacterSteppedInfo : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_UINT64, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_UINT64, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ulong characterId;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float deltaTime;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_QSTRANSFORM, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_QSTRANSFORM, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Matrix3x4 worldFromModel;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_QSTRANSFORM, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_QSTRANSFORM, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Matrix3x4[]? poseModelSpace;
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_QSTRANSFORM, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_QSTRANSFORM, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Matrix3x4[]? rigidAttachmentTransforms;
	}
}
