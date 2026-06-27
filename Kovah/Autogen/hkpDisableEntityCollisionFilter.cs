namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpDisableEntityCollisionFilter : hkpCollisionFilter
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, typeof(hkpEntity), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? disabledEntities;
	}
}
