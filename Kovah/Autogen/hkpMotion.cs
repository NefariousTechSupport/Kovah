namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	public partial class hkpMotion : hkReferencedObject
	{
		public enum MotionType
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			MOTION_INVALID,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			MOTION_DYNAMIC,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			MOTION_SPHERE_INERTIA,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 3)]
			MOTION_BOX_INERTIA,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 4)]
			MOTION_KEYFRAMED,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 5)]
			MOTION_FIXED,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 6)]
			MOTION_THIN_BOX_INERTIA,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 7)]
			MOTION_CHARACTER,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 8)]
			MOTION_MAX_ID,
			
		}
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, null, typeof(hkpMotion.MotionType), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 8, null, typeof(hkpMotion.MotionType), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, typeof(hkpMotion.MotionType), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 8, null, typeof(hkpMotion.MotionType), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hkpMotion.MotionType type;
		[HavokMember(EVersion.Havok_7_1_0_r1, 9, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 9, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 9, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 9, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte deactivationIntegrateCounter;
		[HavokMember(EVersion.Havok_7_1_0_r1, 10, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 10, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 10, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 10, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private ushort deactivationNumInactiveFrames;
		[HavokMember(EVersion.Havok_7_1_0_r1, 16, typeof(hkMotionState), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 16, typeof(hkMotionState), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, typeof(hkMotionState), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 16, typeof(hkMotionState), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkMotionState? motionState;
		[HavokMember(EVersion.Havok_7_1_0_r1, 192, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 192, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 192, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 192, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 inertiaAndMassInv;
		[HavokMember(EVersion.Havok_7_1_0_r1, 208, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 208, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 208, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 208, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 linearVelocity;
		[HavokMember(EVersion.Havok_7_1_0_r1, 224, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 224, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 224, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 224, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 angularVelocity;
		[HavokMember(EVersion.Havok_7_1_0_r1, 240, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 240, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 240, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 240, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private Vector4 deactivationRefPosition;
		[HavokMember(EVersion.Havok_7_1_0_r1, 272, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 272, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 272, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 272, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private uint deactivationRefOrientation;
		[HavokMember(EVersion.Havok_7_1_0_r1, 280, typeof(hkpMaxSizeMotion), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 280, typeof(hkpMaxSizeMotion), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 280, typeof(hkpMaxSizeMotion), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 280, typeof(hkpMaxSizeMotion), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpMaxSizeMotion? savedMotion;
		[HavokMember(EVersion.Havok_7_1_0_r1, 284, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 284, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 284, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 284, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort savedQualityTypeIndex;
		[HavokMember(EVersion.Havok_7_1_0_r1, 286, null, null, Type.TYPE_HALF, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 286, null, null, Type.TYPE_HALF, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 286, null, null, Type.TYPE_HALF, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 286, null, null, Type.TYPE_HALF, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Half gravityFactor;
	}
}
