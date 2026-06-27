namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbRoleAttribute
	{
		public enum Role
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			ROLE_DEFAULT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			ROLE_FILE_NAME,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			ROLE_BONE_INDEX,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			ROLE_BONE_INDEX_MAP,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			ROLE_EVENT_ID,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			ROLE_VARIABLE_INDEX,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			ROLE_ATTRIBUTE_INDEX,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 6)]
			ROLE_TIME,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 7)]
			ROLE_SCRIPT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			ROLE_LOCAL_FRAME,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 9)]
			ROLE_BONE_ATTACHMENT,
			
		}
		public enum RoleFlags
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			FLAG_NONE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			FLAG_RAGDOLL,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			FLAG_NORMALIZED,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			FLAG_NOT_VARIABLE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			FLAG_HIDDEN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			FLAG_OUTPUT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 32)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 32)]
			FLAG_NOT_CHARACTER_PROPERTY,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 64)]
			FLAG_CHAIN,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, typeof(hkbRoleAttribute.Role), Type.TYPE_ENUM, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, typeof(hkbRoleAttribute.Role), Type.TYPE_ENUM, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		private hkbRoleAttribute.Role role;
		[HavokMember(EVersion.hk_2012_1_0_r1, 2, null, typeof(hkbRoleAttribute.RoleFlags), Type.TYPE_FLAGS, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 2, null, typeof(hkbRoleAttribute.RoleFlags), Type.TYPE_FLAGS, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		private hkbRoleAttribute.RoleFlags flags;
	}
}
