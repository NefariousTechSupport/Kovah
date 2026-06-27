namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpPhysicsSystemData : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hknpMaterial), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpMaterial?[]? materials;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, typeof(hknpMotionProperties), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpMotionProperties?[]? motionProperties;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, typeof(hknpMotionCinfo), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpMotionCinfo?[]? motionCinfos;
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, typeof(hknpBodyCinfo), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpBodyCinfo?[]? bodyCinfos;
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, typeof(hknpConstraintCinfo), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpConstraintCinfo?[]? constraintCinfos;
		[HavokMember(EVersion.hk_2014_1_0_r1, 68, typeof(hkReferencedObject), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private object? /* void */[]? referencedObjects;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string? name;
	}
}
