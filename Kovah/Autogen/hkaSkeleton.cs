namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkaSkeleton : hkReferencedObject
	{
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 8, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 8, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_STRINGPTR, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private string? name;
		[HavokMember(EVersion.Havok_7_1_0_r1, 12, null, null, Type.TYPE_ARRAY, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 12, null, null, Type.TYPE_ARRAY, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, null, null, Type.TYPE_ARRAY, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 12, null, null, Type.TYPE_ARRAY, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_ARRAY, Type.TYPE_INT16, 0, FlagValues.FLAGS_NONE)]
		private short[]? parentIndices;
		[HavokMember(EVersion.Havok_7_1_0_r1, 24, typeof(hkaBone), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 24, typeof(hkaBone), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, typeof(hkaBone), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 24, typeof(hkaBone), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, typeof(hkaBone), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkaBone?[]? bones;
		[HavokMember(EVersion.Havok_7_1_0_r1, 36, null, null, Type.TYPE_ARRAY, Type.TYPE_QSTRANSFORM, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 36, null, null, Type.TYPE_ARRAY, Type.TYPE_QSTRANSFORM, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, null, null, Type.TYPE_ARRAY, Type.TYPE_QSTRANSFORM, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 36, null, null, Type.TYPE_ARRAY, Type.TYPE_QSTRANSFORM, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, null, null, Type.TYPE_ARRAY, Type.TYPE_QSTRANSFORM, 0, FlagValues.FLAGS_NONE)]
		private Matrix3x4[]? referencePose;
		[HavokMember(EVersion.Havok_7_1_0_r1, 48, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 60, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 60, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 60, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 60, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		private string?[]? floatSlots;
		[HavokMember(EVersion.Havok_7_1_0_r1, 60, typeof(hkaSkeletonLocalFrameOnBone), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 72, typeof(hkaSkeletonLocalFrameOnBone), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 72, typeof(hkaSkeletonLocalFrameOnBone), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 72, typeof(hkaSkeletonLocalFrameOnBone), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 72, typeof(hkaSkeletonLocalFrameOnBone), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkaSkeletonLocalFrameOnBone?[]? localFrames;
		[HavokMember(EVersion.hk_2011_2_0_r1, 48, null, null, Type.TYPE_ARRAY, Type.TYPE_REAL, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_ARRAY, Type.TYPE_REAL, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 48, null, null, Type.TYPE_ARRAY, Type.TYPE_REAL, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_ARRAY, Type.TYPE_REAL, 0, FlagValues.FLAGS_NONE)]
		private float[]? referenceFloats;
		[HavokMember(EVersion.hk_2012_1_0_r1, 84, typeof(hkaSkeletonPartition), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 84, typeof(hkaSkeletonPartition), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 84, typeof(hkaSkeletonPartition), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkaSkeletonPartition?[]? partitions;
	}
}
