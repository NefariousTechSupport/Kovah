namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkpSphereRepShape))]
	public partial class hkpMultiSphereShape : hkpSphereRepShape
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int numSpheres;
		[HavokMember(EVersion.hk_2012_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 8, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4[] spheres = new Vector4[8];
		public hkpMultiSphereShape()
		{
		}
	}
}
