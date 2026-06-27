namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpDestructionShapeProperties : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_TRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Matrix4x4 /* transform */ worldFromShape;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool isHierarchicalCompound;
		[HavokMember(EVersion.hk_2014_1_0_r1, 81, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool hasDestructionShapes;
	}
}
