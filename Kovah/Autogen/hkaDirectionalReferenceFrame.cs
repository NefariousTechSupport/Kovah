namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkaParameterizedReferenceFrame))]
	[HavokClass(EVersion.hk_2014_1_0_r1, typeof(hkaParameterizedReferenceFrame))]
	public partial class hkaDirectionalReferenceFrame : hkaParameterizedReferenceFrame
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_VECTOR4, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Vector4 movementDir;
		public hkaDirectionalReferenceFrame()
		{
		}
	}
}
