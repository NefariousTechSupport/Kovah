namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbDemoConfigStickVariableInfo
	{
		public enum Stick
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			STICK_0,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			STICK_1,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			STICK_DPAD,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string? variableName;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float minValue;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float maxValue;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float minStickValue;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float maxStickValue;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_INT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private sbyte stickAxis;
		[HavokMember(EVersion.hk_2012_1_0_r1, 21, null, typeof(hkbDemoConfigStickVariableInfo.Stick), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbDemoConfigStickVariableInfo.Stick stick;
		[HavokMember(EVersion.hk_2012_1_0_r1, 22, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool complimentVariableValue;
		[HavokMember(EVersion.hk_2012_1_0_r1, 23, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool negateVariableValue;
	}
}
