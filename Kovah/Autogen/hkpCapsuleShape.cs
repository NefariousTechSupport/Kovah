namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpCapsuleShape : hkpConvexShape
	{
		public enum RayHitType
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			HIT_CAP0,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			HIT_CAP1,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			HIT_BODY,
			
		}
		[HavokMember(EVersion.Havok_7_1_0_r1, 32, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 vertexA;
		[HavokMember(EVersion.Havok_7_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 vertexB;
	}
}
