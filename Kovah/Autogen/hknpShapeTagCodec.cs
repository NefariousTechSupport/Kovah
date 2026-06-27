namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpShapeTagCodec : hkReferencedObject
	{
		public enum Type
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			TYPE_NULL,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			TYPE_MATERIAL_PALETTE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			TYPE_UFM,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			TYPE_USER,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, typeof(hknpShapeTagCodec.Type), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hknpShapeTagCodec.Type type;
	}
}
