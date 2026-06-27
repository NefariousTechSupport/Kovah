namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpDisableEntityCollisionFilter : hkpCollisionFilter
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, typeof(hkpEntity), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? disabledEntities;
	}
}
