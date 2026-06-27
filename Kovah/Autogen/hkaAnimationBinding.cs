namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkaAnimationBinding : hkReferencedObject
	{
		public enum BlendHint
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			NORMAL,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			ADDITIVE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			ADDITIVE_DEPRECATED,
			
		}
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 8, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string? originalSkeletonName;
		[HavokMember(EVersion.Havok_7_1_0_r1, 12, typeof(hkaAnimation), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 12, typeof(hkaAnimation), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 12, typeof(hkaAnimation), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 12, typeof(hkaAnimation), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, typeof(hkaAnimation), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkaAnimation? animation;
		[HavokMember(EVersion.Havok_7_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 16, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short[]? transformTrackToBoneIndices;
		[HavokMember(EVersion.Havok_7_1_0_r1, 28, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 28, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 28, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 28, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short[]? floatTrackToFloatSlotIndices;
		[HavokMember(EVersion.Havok_7_1_0_r1, 40, null, typeof(hkaAnimationBinding.BlendHint), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 40, null, typeof(hkaAnimationBinding.BlendHint), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, typeof(hkaAnimationBinding.BlendHint), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 52, null, typeof(hkaAnimationBinding.BlendHint), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 52, null, typeof(hkaAnimationBinding.BlendHint), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_INT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkaAnimationBinding.BlendHint blendHint;
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 40, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_INT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private short[]? partitionIndices;
	}
}
