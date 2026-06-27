namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpSimpleContactConstraintAtom : hkpConstraintAtom
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 2, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort sizeOfAllAtoms;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort numContactPoints;
		[HavokMember(EVersion.hk_2012_1_0_r1, 6, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort numReservedContactPoints;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte numUserDatasForBodyA;
		[HavokMember(EVersion.hk_2012_1_0_r1, 9, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte numUserDatasForBodyB;
		[HavokMember(EVersion.hk_2012_1_0_r1, 10, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte contactPointPropertiesStriding;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort maxNumContactPoints;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, typeof(hkpSimpleContactConstraintDataInfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.ALIGN_16)]
		private hkpSimpleContactConstraintDataInfo? info;
	}
}
