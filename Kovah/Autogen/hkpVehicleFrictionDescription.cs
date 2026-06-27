namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpVehicleFrictionDescription : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float wheelDistance;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float chassisMassInv;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hkpVehicleFrictionDescriptionAxisDescription), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private hkpVehicleFrictionDescriptionAxisDescription? axleDescr;
	}
}
