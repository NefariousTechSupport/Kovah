namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbLayerGenerator : hkbGenerator
	{
		public enum LayerFlagBits
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			FLAG_SYNC,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, typeof(hkbLayer), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, typeof(hkbLayer), null, Type.TYPE_ARRAY, Type.TYPE_POINTER, 0, FlagValues.FLAGS_NONE)]
		private object? /* void */[]? layers;
		[HavokMember(EVersion.hk_2012_1_0_r1, 104, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 104, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short indexOfSyncMasterChild;
		[HavokMember(EVersion.hk_2012_1_0_r1, 106, null, typeof(hkbLayerGenerator.LayerFlagBits), Type.TYPE_FLAGS, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 106, null, typeof(hkbLayerGenerator.LayerFlagBits), Type.TYPE_FLAGS, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private hkbLayerGenerator.LayerFlagBits flags;
		[HavokMember(EVersion.hk_2012_1_0_r1, 108, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 108, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private int numActiveLayers;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, Type.TYPE_ARRAY, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? layerInternalStates;
		[HavokMember(EVersion.hk_2012_1_0_r1, 124, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 124, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private bool initSync;
	}
}
