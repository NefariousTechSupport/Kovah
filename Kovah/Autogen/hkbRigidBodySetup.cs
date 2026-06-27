namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbRigidBodySetup
	{
		public enum Type
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, -1)]
			INVALID,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			KEYFRAMED,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			DYNAMIC,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			FIXED,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_UINT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private uint collisionFilterInfo;
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, typeof(hkbRigidBodySetup.Type), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbRigidBodySetup.Type type;
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkbShapeSetup), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbShapeSetup? shapeSetup;
	}
}
