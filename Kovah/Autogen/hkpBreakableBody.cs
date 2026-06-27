namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpBreakableBody : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkpBreakableBodyController), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpBreakableBodyController? controller;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, typeof(hkpBreakableShape), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpBreakableShape? breakableShape;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte bodyTypeAndFlags;
		[HavokMember(EVersion.hk_2012_1_0_r1, 18, null, null, Type.TYPE_HALF, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Half constraintStrength;
	}
}
