namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpBreakableShape : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkcdShape), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkcdShape? physicsShape;
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, typeof(hkpBreakableMaterial), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpBreakableMaterial? material;
	}
}
