namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpWheelConstraintData : hkpConstraintData
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, typeof(hkpWheelConstraintDataAtoms), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.ALIGN_16)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hkpWheelConstraintDataAtoms), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.ALIGN_16)]
		private hkpWheelConstraintDataAtoms? atoms;
		[HavokMember(EVersion.hk_2012_1_0_r1, 352, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 352, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 initialAxleInB;
		[HavokMember(EVersion.hk_2012_1_0_r1, 368, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 368, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 initialSteeringAxisInB;
	}
}
