namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkpConstraintAtom))]
	[HavokClass(EVersion.hk_2014_1_0_r1, typeof(hkpConstraintAtom))]
	public partial class hkp3dAngConstraintAtom : hkpConstraintAtom
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 2, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 14, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 2, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 14, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private byte[] padding = new byte[14];
		public hkp3dAngConstraintAtom()
		{
		}
	}
}
