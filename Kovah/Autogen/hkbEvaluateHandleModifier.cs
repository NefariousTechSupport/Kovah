namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbEvaluateHandleModifier : hkbModifier
	{
		public enum HandleChangeMode
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			HANDLE_CHANGE_MODE_ABRUPT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			HANDLE_CHANGE_MODE_CONSTANT_VELOCITY,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkbHandle), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, typeof(hkbHandle), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbHandle? handle;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 handlePositionOut;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion handleRotationOut;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool isValidOut;
		[HavokMember(EVersion.hk_2012_1_0_r1, 100, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 100, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float extrapolationTimeStep;
		[HavokMember(EVersion.hk_2012_1_0_r1, 104, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 104, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float handleChangeSpeed;
		[HavokMember(EVersion.hk_2012_1_0_r1, 108, null, typeof(hkbEvaluateHandleModifier.HandleChangeMode), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 108, null, typeof(hkbEvaluateHandleModifier.HandleChangeMode), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbEvaluateHandleModifier.HandleChangeMode handleChangeMode;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, typeof(hkbHandle), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, typeof(hkbHandle), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private hkbHandle? oldHandle;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private Vector4 oldHandlePosition;
		[HavokMember(EVersion.hk_2012_1_0_r1, 160, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 160, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private Quaternion oldHandleRotation;
		[HavokMember(EVersion.hk_2012_1_0_r1, 176, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 176, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private float timeSinceLastModify;
		[HavokMember(EVersion.hk_2012_1_0_r1, 180, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 180, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool smoothlyChangingHandles;
	}
}
