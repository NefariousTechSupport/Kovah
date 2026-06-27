namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdPlanarGeometryPlanesCollection : hkReferencedObject
	{
		public enum Bounds
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			BOUND_POS_X,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			BOUND_NEG_X,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			BOUND_POS_Y,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			BOUND_NEG_Y,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			BOUND_POS_Z,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			BOUND_NEG_Z,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 6)]
			NUM_BOUNDS,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 offsetAndScale;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, typeof(hkcdPlanarGeometryPrimitivesPlane), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkcdPlanarGeometryPrimitivesPlane?[]? planes;
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ cache;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ criticalAccess;
	}
}
