namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpFirstPersonGun : hkReferencedObject
	{
		public enum KeyboardKey
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 112)]
			KEY_F1,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 113)]
			KEY_F2,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 114)]
			KEY_F3,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 115)]
			KEY_F4,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 116)]
			KEY_F5,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 117)]
			KEY_F6,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 118)]
			KEY_F7,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 119)]
			KEY_F8,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 120)]
			KEY_F9,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 121)]
			KEY_F10,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 122)]
			KEY_F11,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 123)]
			KEY_F12,
			
		}
		public enum Type
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			WEAPON_TYPE_INVALID,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			WEAPON_TYPE_BALLGUN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			WEAPON_TYPE_GRENADEGUN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			WEAPON_TYPE_GRAVITYGUN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			WEAPON_TYPE_MOUNTEDBALLGUN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			WEAPON_TYPE_TWEAKERGUN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			WEAPON_TYPE_MISSILEGUN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 7)]
			WEAPON_TYPE_RAYCASTGUN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			WEAPON_TYPE_SPHEREGUN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 9)]
			WEAPON_TYPE_STICKYGUN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 10)]
			WEAPON_TYPE_NUM_TYPES,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private byte type;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string? name;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, typeof(hkpFirstPersonGun.KeyboardKey), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpFirstPersonGun.KeyboardKey keyboardKey;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? listeners;
	}
}
