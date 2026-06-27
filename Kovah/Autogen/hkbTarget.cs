namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbTarget : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ target;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private Vector4 contactPointTS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private Vector4 contactNormalTS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private Vector4 shapeCentroidTS;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private float distance;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, null, null, Type.TYPE_INT8, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private sbyte targetPriority;
	}
}
