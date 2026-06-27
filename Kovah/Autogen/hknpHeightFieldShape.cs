namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpHeightFieldShape : hknpCompositeShape
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, typeof(hkAabb), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkAabb? aabb;
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 floatToIntScale;
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 intToFloatScale;
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int intSizeX;
		[HavokMember(EVersion.hk_2014_1_0_r1, 148, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int intSizeZ;
		[HavokMember(EVersion.hk_2014_1_0_r1, 152, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int numBitsX;
		[HavokMember(EVersion.hk_2014_1_0_r1, 156, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int numBitsZ;
		[HavokMember(EVersion.hk_2014_1_0_r1, 160, typeof(hknpMinMaxQuadTree), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpMinMaxQuadTree? minMaxTree;
		[HavokMember(EVersion.hk_2014_1_0_r1, 208, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int minMaxTreeCoarseness;
		[HavokMember(EVersion.hk_2014_1_0_r1, 212, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool includeShapeKeyInSdfContacts;
	}
}
