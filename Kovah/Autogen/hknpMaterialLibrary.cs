namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpMaterialLibrary : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ materialAddedSignal;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ materialModifiedSignal;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ materialRemovedSignal;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, typeof(hkFreeListArrayhknpMaterialhknpMaterialId8hknpMaterialFreeListArrayOperations), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkFreeListArrayhknpMaterialhknpMaterialId8hknpMaterialFreeListArrayOperations? entries;
	}
}
