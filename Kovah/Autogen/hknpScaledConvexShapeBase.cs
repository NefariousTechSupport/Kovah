namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpScaledConvexShapeBase : hknpDecoratorShape
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 scale;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 translation;
	}
}
