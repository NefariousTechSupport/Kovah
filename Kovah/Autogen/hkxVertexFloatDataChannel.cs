namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	public partial class hkxVertexFloatDataChannel : hkReferencedObject
	{
		public enum VertexFloatDimensions
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			FLOAT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			DISTANCE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			ANGLE,
			
		}
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_REAL, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float[]? perVertexFloats;
		[HavokMember(EVersion.Havok_7_1_0_r1, 20, null, typeof(hkxVertexFloatDataChannel.VertexFloatDimensions), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkxVertexFloatDataChannel.VertexFloatDimensions dimensions;
	}
}
