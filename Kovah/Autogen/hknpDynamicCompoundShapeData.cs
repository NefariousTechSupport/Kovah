namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpDynamicCompoundShapeData : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hknpDynamicCompoundShapeTree), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpDynamicCompoundShapeTree? aabbTree;
	}
}
