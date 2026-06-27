namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkCompressedMassProperties
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.FLAGS_NONE)]
		private short centerOfMass;
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.FLAGS_NONE)]
		private short inertia;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_INT16, hkClassMember.Type.TYPE_VOID, 4, hkClassMember.FlagValues.FLAGS_NONE)]
		private short majorAxisSpace;
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float mass;
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float volume;
	}
}
