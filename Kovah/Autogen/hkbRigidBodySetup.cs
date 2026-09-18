namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbRigidBodySetup
	{
		public enum Type : int
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
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint collisionFilterInfo;
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, typeof(hkbRigidBodySetup.Type), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbRigidBodySetup.Type type;
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkbShapeSetup), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbShapeSetup? shapeSetup;
	}
}
