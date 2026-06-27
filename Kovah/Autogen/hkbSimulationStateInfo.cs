namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbSimulationStateInfo : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, typeof(hkbWorldEnums.SimulationState), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, typeof(hkbWorldEnums.SimulationState), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbWorldEnums.SimulationState simulationState;
	}
}
