namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpShape : hkReferencedObject
	{
		public enum FlagsEnum
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			IS_CONVEX_SHAPE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			IS_CONVEX_POLYTOPE_SHAPE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			IS_COMPOSITE_SHAPE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			IS_HEIGHT_FIELD_SHAPE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			USE_SINGLE_POINT_MANIFOLD,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 32)]
			IS_INTERIOR_TRIANGLE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 64)]
			SUPPORTS_COLLISIONS_WITH_INTERIOR_TRIANGLES,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 128)]
			USE_NORMAL_TO_FIND_SUPPORT_PLANE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 256)]
			USE_SMALL_FACE_INDICES,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 512)]
			NO_GET_SHAPE_KEYS_ON_SPU,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1024)]
			SHAPE_NOT_SUPPORTED_ON_SPU,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2048)]
			IS_TRIANGLE_OR_QUAD_SHAPE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4096)]
			IS_QUAD_SHAPE,
			
		}
		public enum ScaleMode
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			SCALE_SURFACE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			SCALE_VERTICES,
			
		}
		public enum ConvexRadiusDisplayMode
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			CONVEX_RADIUS_DISPLAY_NONE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			CONVEX_RADIUS_DISPLAY_PLANAR,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			CONVEX_RADIUS_DISPLAY_ROUNDED,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, typeof(hknpShape.FlagsEnum), Type.TYPE_FLAGS, Type.TYPE_UINT16, 0, FlagValues.ALIGN_16)]
		private hknpShape.FlagsEnum flags;
		[HavokMember(EVersion.hk_2014_1_0_r1, 18, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte numShapeKeyBits;
		[HavokMember(EVersion.hk_2014_1_0_r1, 19, null, typeof(hknpCollisionDispatchType.Enum), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hknpCollisionDispatchType.Enum dispatchType;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float convexRadius;
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, null, null, Type.TYPE_UINT64, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ulong userData;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, typeof(hkRefCountedProperties), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkRefCountedProperties? properties;
	}
}
