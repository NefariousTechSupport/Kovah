namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2013_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkaPredictiveCompressedAnimation : hkaAnimation
	{
		public enum StorageClass
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			STORAGE_STATIC,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			STORAGE_REFERENCE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			STORAGE_DYNAMIC_RANGE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			STORAGE_DYNAMIC_FIXED,
			
		}
		public enum IntArrayID
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			BLOCK_OFFSETS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			FIRST_FLOAT_BLOCK_OFFSETS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			IS_ANIMATED_BITMAP,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			IS_FIXED_RANGE_BITMAP,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 4)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			DYNAMIC_BONE_TRACK_INDEX,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 5)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 5)]
			DYNAMIC_FLOAT_TRACK_INDEX,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 6)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 6)]
			STATIC_BONE_TRACK_INDEX,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 7)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 7)]
			STATIC_FLOAT_TRACK_INDEX,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 8)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			RENORM_QUATERNION_INDEX,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 9)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 9)]
			NUM_INT_ARRAYS,
			
		}
		public enum FloatArrayID
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			STATIC_VALUES,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			DYNAMIC_SCALES,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			DYNAMIC_OFFSETS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2013_1_0_r1, 3)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			NUM_FLOAT_ARRAYS,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 40, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 40, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte[]? compressedData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 52, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 52, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_UINT16, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort[]? intData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 9, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 9, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 9, hkClassMember.FlagValues.FLAGS_NONE)]
		private int intArrayOffsets;
		[HavokMember(EVersion.hk_2012_1_0_r1, 100, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_REAL, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 100, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_REAL, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 100, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_REAL, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float[]? floatData;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 3, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 112, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 3, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 3, hkClassMember.FlagValues.FLAGS_NONE)]
		private int floatArrayOffsets;
		[HavokMember(EVersion.hk_2012_1_0_r1, 124, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 124, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int numBones;
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int numFloatSlots;
		[HavokMember(EVersion.hk_2012_1_0_r1, 132, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 132, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 132, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int numFrames;
		[HavokMember(EVersion.hk_2012_1_0_r1, 136, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 136, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 136, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int firstFloatBlockScaleAndOffsetIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 140, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 140, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 140, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ skeleton;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2013_1_0_r1, 144, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private int maxCompressedBytesPerFrame;
	}
}
