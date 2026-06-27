namespace Kovah
{
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	public partial class hkxSpline : hkReferencedObject
	{
		public enum ControlType
		{
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			BEZIER_SMOOTH,
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			BEZIER_CORNER,
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			LINEAR,
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 3)]
			CUSTOM,
			
		}
		[HavokMember(EVersion.hk_2013_1_0_r1, 8, typeof(hkxSplineControlPoint), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkxSplineControlPoint?[]? controlPoints;
		[HavokMember(EVersion.hk_2013_1_0_r1, 20, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool isClosed;
	}
}
