namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbVariableInfo
	{
		public enum VariableType
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, -1)]
			VARIABLE_TYPE_INVALID,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			VARIABLE_TYPE_BOOL,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			VARIABLE_TYPE_INT8,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			VARIABLE_TYPE_INT16,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			VARIABLE_TYPE_INT32,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			VARIABLE_TYPE_REAL,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			VARIABLE_TYPE_POINTER,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 6)]
			VARIABLE_TYPE_VECTOR3,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 7)]
			VARIABLE_TYPE_VECTOR4,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			VARIABLE_TYPE_QUATERNION,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkbRoleAttribute), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkbRoleAttribute), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbRoleAttribute? role;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, typeof(hkbVariableInfo.VariableType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, typeof(hkbVariableInfo.VariableType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbVariableInfo.VariableType type;
	}
}
