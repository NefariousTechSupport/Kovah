namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	public partial class hkxVertexVectorDataChannel : hkReferencedObject
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VECTOR4, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4[]? perVertexVectors;
	}
}
