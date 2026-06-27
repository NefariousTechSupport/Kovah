namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkUiAttribute
	{
		public enum HideInModeler
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			NONE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			MAX,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			MAYA,
			
		}
		public enum HideCriteria
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			NONE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			MODELER_IS_MAX,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			MODELER_IS_MAYA,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			UI_SCHEME_IS_DESTRUCTION,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			UI_SCHEME_IS_DESTRUCTION_2012,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool visible;
		[HavokMember(EVersion.hk_2012_1_0_r1, 1, null, typeof(hkUiAttribute.HideInModeler), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkUiAttribute.HideInModeler hideInModeler;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, Type.TYPE_CSTRING, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, Type.TYPE_CSTRING, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? label;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_CSTRING, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_CSTRING, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? group;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_CSTRING, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_CSTRING, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? hideBaseClassMembers;
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool endGroup;
		[HavokMember(EVersion.hk_2012_1_0_r1, 17, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 17, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool endGroup2;
		[HavokMember(EVersion.hk_2012_1_0_r1, 18, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 18, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool advanced;
		[HavokMember(EVersion.hk_2014_1_0_r1, 1, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool editable;
		[HavokMember(EVersion.hk_2014_1_0_r1, 2, null, typeof(hkUiAttribute.HideCriteria), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkUiAttribute.HideCriteria hideCriteria;
	}
}
