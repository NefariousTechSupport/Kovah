namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpShapeInstance
	{
		public enum Flags
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			HAS_TRANSLATION,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			HAS_ROTATION,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			HAS_SCALE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			FLIP_ORIENTATION,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 32)]
			SCALE_SURFACE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 64)]
			IS_ENABLED,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 64)]
			DEFAULT_FLAGS,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_TRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Matrix4x4 /* transform */ transform;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 scale;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, typeof(hknpShape), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpShape? shape;
		[HavokMember(EVersion.hk_2014_1_0_r1, 84, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort shapeTag;
		[HavokMember(EVersion.hk_2014_1_0_r1, 86, null, null, Type.TYPE_UINT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private ushort destructionTag;
		[HavokMember(EVersion.hk_2014_1_0_r1, 88, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 30, FlagValues.FLAGS_NONE)]
		private byte padding;
	}
}
