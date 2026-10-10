namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1, typeof(hkpShape))]
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkpShape))]
	public partial class hkpBvShape : hkpShape
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 16, typeof(hkpShape), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, typeof(hkpShape), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpShape? boundingVolumeShape;
		[HavokMember(EVersion.Havok_7_1_0_r1, 20, typeof(hkpSingleShapeContainer), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, typeof(hkpSingleShapeContainer), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpSingleShapeContainer? childShape;
		public hkpBvShape()
		{
		}
	}
}
