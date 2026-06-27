namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2011_2_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkpConstraintData : hkReferencedObject
	{
		public enum ConstraintType : int
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			CONSTRAINT_TYPE_BALLANDSOCKET,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			CONSTRAINT_TYPE_HINGE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			CONSTRAINT_TYPE_LIMITEDHINGE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			CONSTRAINT_TYPE_POINTTOPATH,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 6)]
			CONSTRAINT_TYPE_PRISMATIC,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 7)]
			CONSTRAINT_TYPE_RAGDOLL,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			CONSTRAINT_TYPE_STIFFSPRING,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 9)]
			CONSTRAINT_TYPE_WHEEL,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 10)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 10)]
			CONSTRAINT_TYPE_GENERIC,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 11)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 11)]
			CONSTRAINT_TYPE_CONTACT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 12)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 12)]
			CONSTRAINT_TYPE_BREAKABLE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 13)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 13)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 13)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 13)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 13)]
			CONSTRAINT_TYPE_MALLEABLE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 14)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 14)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 14)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 14)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 14)]
			CONSTRAINT_TYPE_POINTTOPLANE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 15)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 15)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 15)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 15)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 15)]
			CONSTRAINT_TYPE_PULLEY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 16)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			CONSTRAINT_TYPE_ROTATIONAL,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 18)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 18)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 18)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 18)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 18)]
			CONSTRAINT_TYPE_HINGE_LIMITS,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 19)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 19)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 19)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 19)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 19)]
			CONSTRAINT_TYPE_RAGDOLL_LIMITS,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 20)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 20)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 20)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 20)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 20)]
			CONSTRAINT_TYPE_CUSTOM,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 100)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 100)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 100)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 100)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 100)]
			BEGIN_CONSTRAINT_CHAIN_TYPES,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 100)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 100)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 100)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 100)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 100)]
			CONSTRAINT_TYPE_STIFF_SPRING_CHAIN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 101)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 101)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 101)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 101)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 101)]
			CONSTRAINT_TYPE_BALL_SOCKET_CHAIN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, 102)]
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 102)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 102)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 102)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 102)]
			CONSTRAINT_TYPE_POWERED_CHAIN,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 21)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 21)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 21)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 21)]
			CONSTRAINT_TYPE_RACK_AND_PINION,
			[HavokEnumItem(EVersion.hk_2011_2_0_r1, 22)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 22)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 22)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 22)]
			CONSTRAINT_TYPE_COG_WHEEL,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 23)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 23)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 23)]
			CONSTRAINT_TYPE_FIXED,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 24)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 24)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 24)]
			CONSTRAINT_TYPE_DEFORMABLE_FIXED,
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 25)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 25)]
			CONSTRAINT_TYPE_LINEAR_SLACK,
			
		}
		[HavokMember(EVersion.Havok_7_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_ULONG, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2011_2_0_r1, 8, null, null, hkClassMember.Type.TYPE_ULONG, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_ULONG, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_ULONG, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_ULONG, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ulong userData;
	}
}
