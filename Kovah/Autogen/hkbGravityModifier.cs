namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbGravityModifier : hkbModifier
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 initialVelocityInMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float gravityConstant;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private Vector4 currentVelocityInMS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private float secondsElapsed;
	}
}
