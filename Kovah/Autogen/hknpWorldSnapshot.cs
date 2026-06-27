namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpWorldSnapshot : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hknpWorldCinfo), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpWorldCinfo? worldCinfo;
		[HavokMember(EVersion.hk_2014_1_0_r1, 208, typeof(hknpBody), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpBody?[]? bodies;
		[HavokMember(EVersion.hk_2014_1_0_r1, 220, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRINGPTR, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private string?[]? bodyNames;
		[HavokMember(EVersion.hk_2014_1_0_r1, 232, typeof(hknpMotion), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpMotion?[]? motions;
		[HavokMember(EVersion.hk_2014_1_0_r1, 244, typeof(hknpConstraintCinfo), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpConstraintCinfo?[]? constraints;
	}
}
