namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdShape : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, null, null, Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 8, null, null, Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.SERIALIZE_IGNORED)]
		private byte type;
		[HavokMember(EVersion.hk_2012_1_0_r1, 9, null, typeof(hkcdShapeDispatchType.ShapeDispatchTypeEnum), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 9, null, typeof(hkcdShapeDispatchType.ShapeDispatchTypeEnum), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 9, null, typeof(hkcdShapeDispatchType.ShapeDispatchTypeEnum), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hkcdShapeDispatchType.ShapeDispatchTypeEnum dispatchType;
		[HavokMember(EVersion.hk_2012_1_0_r1, 10, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 10, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 10, null, null, Type.TYPE_UINT8, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private byte bitsPerKey;
		[HavokMember(EVersion.hk_2012_1_0_r1, 11, null, typeof(hkcdShapeInfoCodecType.ShapeInfoCodecTypeEnum), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 11, null, typeof(hkcdShapeInfoCodecType.ShapeInfoCodecTypeEnum), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 11, null, typeof(hkcdShapeInfoCodecType.ShapeInfoCodecTypeEnum), Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.FLAGS_NONE)]
		private hkcdShapeInfoCodecType.ShapeInfoCodecTypeEnum shapeInfoCodecType;
	}
}
