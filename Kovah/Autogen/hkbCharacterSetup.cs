namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbCharacterSetup : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkaSkeletonMapper), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkaSkeletonMapper), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? retargetingSkeletonMappers;
		[HavokMember(EVersion.hk_2012_1_0_r1, 20, typeof(hkaSkeleton), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, typeof(hkaSkeleton), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkaSkeleton? animationSkeleton;
		[HavokMember(EVersion.hk_2012_1_0_r1, 24, typeof(hkaSkeletonMapper), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, typeof(hkaSkeletonMapper), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkaSkeletonMapper? ragdollToAnimationSkeletonMapper;
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, typeof(hkaSkeletonMapper), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, typeof(hkaSkeletonMapper), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkaSkeletonMapper? animationToRagdollSkeletonMapper;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ animationBindingSet;
		[HavokMember(EVersion.hk_2012_1_0_r1, 36, typeof(hkbCharacterData), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, typeof(hkbCharacterData), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbCharacterData? data;
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ unscaledAnimationSkeleton;
		[HavokMember(EVersion.hk_2012_1_0_r1, 44, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ mirroredSkeleton;
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ characterPropertyIdMap;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 52, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ criticalSection;
	}
}
