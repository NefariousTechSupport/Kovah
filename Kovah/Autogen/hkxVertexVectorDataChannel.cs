namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	public partial class hkxVertexVectorDataChannel : hkReferencedObject
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, null, null, Type.TYPE_ARRAY, Type.TYPE_VECTOR4, 0, FlagValues.FLAGS_NONE)]
		private Vector4[]? perVertexVectors;
	}
}
