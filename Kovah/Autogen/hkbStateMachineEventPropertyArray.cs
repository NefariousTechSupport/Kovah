namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1, typeof(hkReferencedObject))]
	[HavokClass(EVersion.hk_2014_1_0_r1, typeof(hkReferencedObject))]
	public partial class hkbStateMachineEventPropertyArray : hkReferencedObject
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 8, typeof(hkbEventProperty), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkbEventProperty), null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkbEventProperty?[]? events;
		public hkbStateMachineEventPropertyArray()
		{
		}
	}
}
