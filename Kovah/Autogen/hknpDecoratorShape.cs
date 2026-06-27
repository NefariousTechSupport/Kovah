namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpDecoratorShape : hknpShape
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, typeof(hknpShape), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hknpShape? coreShape;
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int coreShapeSize;
	}
}
