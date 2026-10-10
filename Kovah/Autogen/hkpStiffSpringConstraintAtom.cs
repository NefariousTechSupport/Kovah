namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkpConstraintAtom))]
	[HavokClass(EVersion.hk_2014_1_0_r1, typeof(hkpConstraintAtom))]
	public partial class hkpStiffSpringConstraintAtom : hkpConstraintAtom
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 4, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float length;
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float maxLength;
		public hkpStiffSpringConstraintAtom()
		{
		}
	}
}
