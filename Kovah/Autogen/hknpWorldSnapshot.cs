namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpWorldSnapshot : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hknpWorldCinfo), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hknpWorldCinfo? worldCinfo;
		[HavokMember(EVersion.hk_2014_1_0_r1, 208, typeof(hknpBody), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpBody?[]? bodies;
		[HavokMember(EVersion.hk_2014_1_0_r1, 220, null, null, Type.TYPE_ARRAY, Type.TYPE_STRINGPTR, 0, FlagValues.FLAGS_NONE)]
		private string?[]? bodyNames;
		[HavokMember(EVersion.hk_2014_1_0_r1, 232, typeof(hknpMotion), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpMotion?[]? motions;
		[HavokMember(EVersion.hk_2014_1_0_r1, 244, typeof(hknpConstraintCinfo), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpConstraintCinfo?[]? constraints;
	}
}
