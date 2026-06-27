namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbTwistModifier : hkbModifier
	{
		public enum SetAngleMethod
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			LINEAR,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			RAMPED,
			
		}
		public enum RotationAxisCoordinates
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			ROTATION_AXIS_IN_MODEL_COORDINATES,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			ROTATION_AXIS_IN_LOCAL_COORDINATES,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			ROTATION_AXIS_IN_PARENT_COORDINATES,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 axisOfRotation;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float twistAngle;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 68, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short startBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 70, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 70, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short endBoneIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 72, null, typeof(hkbTwistModifier.SetAngleMethod), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 72, null, typeof(hkbTwistModifier.SetAngleMethod), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbTwistModifier.SetAngleMethod setAngleMethod;
		[HavokMember(EVersion.hk_2012_1_0_r1, 73, null, typeof(hkbTwistModifier.RotationAxisCoordinates), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 73, null, typeof(hkbTwistModifier.RotationAxisCoordinates), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbTwistModifier.RotationAxisCoordinates rotationAxisCoordinates;
		[HavokMember(EVersion.hk_2012_1_0_r1, 74, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 74, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool isAdditive;
		[HavokMember(EVersion.hk_2012_1_0_r1, 76, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 76, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? boneChainIndices;
		[HavokMember(EVersion.hk_2012_1_0_r1, 88, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 88, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? parentBoneIndices;
	}
}
