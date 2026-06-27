namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpVehicleLinearCastWheelCollideWheelState
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkAabb), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkAabb? aabb;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, typeof(hknpShape), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpShape? shape;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_TRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Matrix4x4 /* transform */ transform;
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 to;
	}
}
