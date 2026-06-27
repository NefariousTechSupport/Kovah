namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkGizmoAttribute
	{
		public enum GizmoType
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			POINT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			SPHERE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			PLANE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			ARROW,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool visible;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, hkClassMember.Type.TYPE_CSTRING, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, hkClassMember.Type.TYPE_CSTRING, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string? label;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, typeof(hkGizmoAttribute.GizmoType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, typeof(hkGizmoAttribute.GizmoType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkGizmoAttribute.GizmoType type;
	}
}
