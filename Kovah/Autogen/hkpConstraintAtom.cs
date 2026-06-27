namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpConstraintAtom
	{
		public enum AtomType
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			TYPE_INVALID,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			TYPE_BRIDGE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			TYPE_SET_LOCAL_TRANSFORMS,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			TYPE_SET_LOCAL_TRANSLATIONS,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			TYPE_SET_LOCAL_ROTATIONS,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			TYPE_BALL_SOCKET,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 6)]
			TYPE_STIFF_SPRING,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 7)]
			TYPE_LIN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			TYPE_LIN_SOFT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 9)]
			TYPE_LIN_LIMIT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 10)]
			TYPE_LIN_FRICTION,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 11)]
			TYPE_LIN_MOTOR,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 12)]
			TYPE_2D_ANG,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 13)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 13)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 13)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 13)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 13)]
			TYPE_ANG,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 14)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 14)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 14)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 14)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 14)]
			TYPE_ANG_LIMIT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 15)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 15)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 15)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 15)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 15)]
			TYPE_TWIST_LIMIT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			TYPE_CONE_LIMIT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 17)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 17)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 17)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 17)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 17)]
			TYPE_ANG_FRICTION,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 18)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 18)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 18)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 18)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 18)]
			TYPE_ANG_MOTOR,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 19)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 19)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 19)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 19)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 19)]
			TYPE_RAGDOLL_MOTOR,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 20)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 20)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 20)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 20)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 20)]
			TYPE_PULLEY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 21)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 24)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 27)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 27)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 27)]
			TYPE_OVERWRITE_PIVOT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 22)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 25)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 28)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 28)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 29)]
			TYPE_CONTACT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 23)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 26)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 29)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 29)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 30)]
			TYPE_MODIFIER_SOFT_CONTACT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 24)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 27)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 30)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 30)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 31)]
			TYPE_MODIFIER_MASS_CHANGER,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 25)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 28)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 31)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 31)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 32)]
			TYPE_MODIFIER_VISCOUS_SURFACE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 26)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 29)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 33)]
			TYPE_MODIFIER_MOVING_SURFACE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 27)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 30)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 33)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 33)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 34)]
			TYPE_MODIFIER_IGNORE_CONSTRAINT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 28)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 31)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 34)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 34)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 35)]
			TYPE_MODIFIER_CENTER_OF_MASS_CHANGER,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 29)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 35)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 35)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 36)]
			TYPE_MAX,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 21)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 21)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 21)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 21)]
			TYPE_RACK_AND_PINION,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 22)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 22)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 22)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 22)]
			TYPE_COG_WHEEL,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 23)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 23)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 23)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 23)]
			TYPE_SETUP_STABILIZATION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 24)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 24)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 24)]
			TYPE_3D_ANG,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 25)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 25)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 25)]
			TYPE_DEFORMABLE_3D_LIN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 26)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 26)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 26)]
			TYPE_DEFORMABLE_3D_ANG,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 29)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 29)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 30)]
			FIRST_MODIFIER_TYPE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 34)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 34)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 35)]
			LAST_MODIFIER_TYPE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 28)]
			TYPE_WHEEL_FRICTION,
			
		}
		public enum CallbackRequest
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			CALLBACK_REQUEST_NONE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			CALLBACK_REQUEST_NEW_CONTACT_POINT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			CALLBACK_REQUEST_SETUP_PPU_ONLY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			CALLBACK_REQUEST_SETUP_CALLBACK,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			CALLBACK_REQUEST_CONTACT_POINT_CALLBACK,
			
		}
		public enum SolvingMethod
		{
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			METHOD_STABILIZED,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			METHOD_OLD,
			
		}
		[HavokMember(EVersion.Havok_7_1_0_r1, 0, null, typeof(hkpConstraintAtom.AtomType), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 0, null, typeof(hkpConstraintAtom.AtomType), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, typeof(hkpConstraintAtom.AtomType), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 0, null, typeof(hkpConstraintAtom.AtomType), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, typeof(hkpConstraintAtom.AtomType), Type.TYPE_ENUM, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private hkpConstraintAtom.AtomType type;
	}
}
