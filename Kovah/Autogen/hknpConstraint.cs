namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpConstraint
	{
		[Flags]
		public enum FlagsEnum : int
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			NO_FLAGS,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			IS_EXPORTABLE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			IS_IMMEDIATE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 4)]
			IS_DISABLED,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 8)]
			IS_DESTRUCTION_INTERNAL,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 16)]
			AUTO_REMOVE_ON_DESTRUCTION_RESET,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 32)]
			AUTO_REMOVE_ON_DESTRUCTION,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 64)]
			RAISE_CONSTRAINT_FORCE_EVENTS,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 128)]
			RAISE_CONSTRAINT_FORCE_EXCEEDED_EVENTS,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint bodyIdA;
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint bodyIdB;
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, typeof(hkpConstraintData), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpConstraintData? data;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint id;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private ushort immediateId;
		[HavokMember(EVersion.hk_2014_1_0_r1, 18, null, typeof(hknpConstraint.FlagsEnum), hkClassMember.Type.TYPE_FLAGS, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpConstraint.FlagsEnum flags;
		[HavokMember(EVersion.hk_2014_1_0_r1, 19, null, typeof(hkpConstraintData.ConstraintType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkpConstraintData.ConstraintType type;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ atoms;
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort sizeOfAtoms;
		[HavokMember(EVersion.hk_2014_1_0_r1, 26, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort sizeOfSchemas;
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte numSolverResults;
		[HavokMember(EVersion.hk_2014_1_0_r1, 29, null, null, hkClassMember.Type.TYPE_UINT8, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private byte numSolverElemTemps;
		[HavokMember(EVersion.hk_2014_1_0_r1, 30, null, null, hkClassMember.Type.TYPE_UINT16, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ushort runtimeSize;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ runtime;
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, null, null, hkClassMember.Type.TYPE_UINT64, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private ulong userData;
	}
}
