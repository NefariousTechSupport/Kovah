namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpShapeSignals
	{
		public enum MutationFlagsEnum
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			MUTATION_AABB_CHANGED,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			MUTATION_UPDATE_COLLISION_CACHES,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			MUTATION_REBUILD_COLLISION_CACHES,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ shapeMutated;
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ shapeDestroyed;
	}
}
