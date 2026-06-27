namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpVehicleFrictionDescription : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float wheelDistance;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float chassisMassInv;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hkpVehicleFrictionDescriptionAxisDescription), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 2, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpVehicleFrictionDescriptionAxisDescription? axleDescr;
	}
}
