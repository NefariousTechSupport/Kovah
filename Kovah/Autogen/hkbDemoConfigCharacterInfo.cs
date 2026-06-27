namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbDemoConfigCharacterInfo : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? overrideCharacterDataFilename;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? overrideBehaviorFilename;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 initialPosition;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion initialRotation;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int modelUpAxis;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_ARRAY, Type.TYPE_INT32, 0, FlagValues.FLAGS_NONE)]
		private int[]? ragdollBoneLayers;
	}
}
