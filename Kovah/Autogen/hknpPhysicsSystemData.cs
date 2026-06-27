namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpPhysicsSystemData : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hknpMaterial), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpMaterial?[]? materials;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, typeof(hknpMotionProperties), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpMotionProperties?[]? motionProperties;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, typeof(hknpMotionCinfo), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpMotionCinfo?[]? motionCinfos;
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, typeof(hknpBodyCinfo), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpBodyCinfo?[]? bodyCinfos;
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, typeof(hknpConstraintCinfo), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpConstraintCinfo?[]? constraintCinfos;
		[HavokMember(EVersion.hk_2014_1_0_r1, 68, typeof(hkReferencedObject), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? referencedObjects;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? name;
	}
}
