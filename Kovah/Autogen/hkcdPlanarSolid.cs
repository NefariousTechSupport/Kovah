namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkcdPlanarSolid : hkcdPlanarEntity
	{
		public enum NodeTypes : int
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			NODE_TYPE_INTERNAL,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			NODE_TYPE_IN,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			NODE_TYPE_OUT,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			NODE_TYPE_UNKNOWN,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			NODE_TYPE_INVALID,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 15)]
			NODE_TYPE_FREE,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, typeof(hkcdPlanarSolidNodeStorage), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkcdPlanarSolidNodeStorage? nodes;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, typeof(hkcdPlanarGeometryPlanesCollection), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkcdPlanarGeometryPlanesCollection? planes;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint rootNodeId;
	}
}
