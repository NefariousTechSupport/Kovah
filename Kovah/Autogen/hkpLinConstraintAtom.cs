namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpLinConstraintAtom : hkpConstraintAtom
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 2, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 2, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte axisIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 3, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 12, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 3, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 12, FlagValues.SERIALIZE_IGNORED)]
		private byte padding;
	}
}
