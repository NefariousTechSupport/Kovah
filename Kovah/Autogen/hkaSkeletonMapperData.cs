namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkaSkeletonMapperData
	{
		public enum MappingType : int
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			HK_RAGDOLL_MAPPING,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			HK_RETARGETING_MAPPING,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 0, typeof(hkaSkeleton), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkaSkeleton), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkaSkeleton? skeletonA;
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, typeof(hkaSkeleton), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, typeof(hkaSkeleton), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkaSkeleton? skeletonB;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short[]? partitionMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, typeof(hkaSkeletonMapperDataPartitionMappingRange), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, typeof(hkaSkeletonMapperDataPartitionMappingRange), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkaSkeletonMapperDataPartitionMappingRange?[]? simpleMappingPartitionRanges;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, typeof(hkaSkeletonMapperDataPartitionMappingRange), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, typeof(hkaSkeletonMapperDataPartitionMappingRange), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkaSkeletonMapperDataPartitionMappingRange?[]? chainMappingPartitionRanges;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, typeof(hkaSkeletonMapperDataSimpleMapping), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, typeof(hkaSkeletonMapperDataSimpleMapping), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkaSkeletonMapperDataSimpleMapping?[]? simpleMappings;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, typeof(hkaSkeletonMapperDataChainMapping), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, typeof(hkaSkeletonMapperDataChainMapping), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkaSkeletonMapperDataChainMapping?[]? chainMappings;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 68, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short[]? unmappedBones;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_QSTRANSFORM, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_QSTRANSFORM, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Matrix3x4 extractedMotionMapping;
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool keepUnmappedLocal;
		[HavokMember(EVersion.hk_2012_1_0_r1, 132, null, typeof(hkaSkeletonMapperData.MappingType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 132, null, typeof(hkaSkeletonMapperData.MappingType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT32, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkaSkeletonMapperData.MappingType mappingType;
	}
}
