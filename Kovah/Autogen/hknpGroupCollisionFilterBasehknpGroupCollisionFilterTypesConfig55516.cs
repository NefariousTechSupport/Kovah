namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpGroupCollisionFilterBasehknpGroupCollisionFilterTypesConfig55516 : hknpCollisionFilter
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.ALIGN_16)]
		private int nextFreeSystemGroup;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 32, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint collisionLookupTable;
	}
}
