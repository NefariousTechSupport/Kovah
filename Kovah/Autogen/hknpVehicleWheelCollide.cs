namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpVehicleWheelCollide : hkReferencedObject
	{
		public enum WheelCollideType
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			INVALID_WHEEL_COLLIDE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			RAY_CAST_WHEEL_COLLIDE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			LINEAR_CAST_WHEEL_COLLIDE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			USER_WHEEL_COLLIDE1,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			USER_WHEEL_COLLIDE2,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			USER_WHEEL_COLLIDE3,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 6)]
			USER_WHEEL_COLLIDE4,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 7)]
			USER_WHEEL_COLLIDE5,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool alreadyUsed;
		[HavokMember(EVersion.hk_2014_1_0_r1, 9, null, null, Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.SERIALIZE_IGNORED)]
		private byte type;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private uint wheelCollisionFilterInfo;
	}
}
