namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpBallGun : hkpFirstPersonGun
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float bulletRadius;
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float bulletVelocity;
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float bulletMass;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float damageMultiplier;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int maxBulletsInWorld;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 bulletOffsetFromCenter;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ addedBodies;
	}
}
