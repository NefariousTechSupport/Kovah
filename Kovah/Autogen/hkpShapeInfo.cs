namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkpShapeInfo : hkReferencedObject
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, typeof(hkpShape), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkpShape), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkpShape? shape;
		[HavokMember(EVersion.Havok_7_1_0_r1, 12, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool isHierarchicalCompound;
		[HavokMember(EVersion.Havok_7_1_0_r1, 13, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 13, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private bool hkdShapesCollected;
		[HavokMember(EVersion.Havok_7_1_0_r1, 16, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		private string?[]? childShapeNames;
		[HavokMember(EVersion.Havok_7_1_0_r1, 28, null, null, Type.TYPE_ARRAY, Type.TYPE_TRANSFORM, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, Type.TYPE_ARRAY, Type.TYPE_TRANSFORM, 0, FlagValues.FLAGS_NONE)]
		private Matrix4x4 /* transform */[]? childTransforms;
		[HavokMember(EVersion.Havok_7_1_0_r1, 48, null, null, Type.TYPE_TRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_TRANSFORM, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Matrix4x4 /* transform */ transform;
	}
}
