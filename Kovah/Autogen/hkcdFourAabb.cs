namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdFourAabb
	{
		public enum BoundIndex
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			X_MIN,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			X_MAX,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			Y_MIN,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			Y_MAX,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			Z_MIN,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			Z_MAX,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 lx;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 hx;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 ly;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 hy;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 lz;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 hz;
	}
}
