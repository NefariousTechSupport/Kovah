namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpScaledConvexShape : hknpScaledConvexShapeBase
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, typeof(hknpShapeSignals), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private hknpShapeSignals? mutationSignals;
	}
}
