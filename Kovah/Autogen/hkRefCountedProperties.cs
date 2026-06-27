namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkRefCountedProperties : hkReferencedObject
	{
		public enum ReferenceCountHandling
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			REFERENCE_COUNT_INCREMENT,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			REFERENCE_COUNT_IGNORE,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkRefCountedPropertiesEntry), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, typeof(hkRefCountedPropertiesEntry), null, Type.TYPE_ARRAY, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkRefCountedPropertiesEntry?[]? entries;
	}
}
