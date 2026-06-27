namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpBallGun : hkpFirstPersonGun
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float bulletRadius;
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float bulletVelocity;
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float bulletMass;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float damageMultiplier;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int maxBulletsInWorld;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 bulletOffsetFromCenter;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ addedBodies;
	}
}
