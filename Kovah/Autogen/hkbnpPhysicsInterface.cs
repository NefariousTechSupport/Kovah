namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbnpPhysicsInterface : hkbPhysicsInterface
	{
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ world;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ taskQueue;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ threadPool;
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ stepLocalAllocator;
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, typeof(hkMultiThreadCheck), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private hkMultiThreadCheck? multiThreadCheck;
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ criticalSection;
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? newRbHandles;
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? newConstraintHandles;
		[HavokMember(EVersion.hk_2014_1_0_r1, 68, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? referencedRbHandles;
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? referencedConstraintHandles;
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, null, null, hkClassMember.Type.TYPE_ARRAY, hkClassMember.Type.TYPE_POINTER, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */[]? referencedBodiesLocalFrames;
	}
}
