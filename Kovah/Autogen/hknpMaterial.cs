namespace Kovah
{
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hknpMaterial
	{
		public enum TriggerType
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			TRIGGER_TYPE_NONE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			TRIGGER_TYPE_BROAD_PHASE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			TRIGGER_TYPE_NARROW_PHASE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 3)]
			TRIGGER_TYPE_CONTACT_SOLVER,
			
		}
		public enum CombinePolicy
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			COMBINE_AVG,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			COMBINE_MIN,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			COMBINE_MAX,
			
		}
		public enum MassChangerCategory
		{
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			MASS_CHANGER_IGNORE,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			MASS_CHANGER_DEBRIS,
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			MASS_CHANGER_HEAVY,
			
		}
		[HavokMember(EVersion.hk_2014_1_0_r1, 0, null, null, hkClassMember.Type.TYPE_STRINGPTR, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.ALIGN_16)]
		private string? name;
		[HavokMember(EVersion.hk_2014_1_0_r1, 4, null, null, hkClassMember.Type.TYPE_UINT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private uint isExclusive;
		[HavokMember(EVersion.hk_2014_1_0_r1, 8, null, null, hkClassMember.Type.TYPE_INT32, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private int flags;
		[HavokMember(EVersion.hk_2014_1_0_r1, 12, null, typeof(hknpMaterial.TriggerType), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpMaterial.TriggerType triggerType;
		[HavokMember(EVersion.hk_2014_1_0_r1, 13, typeof(hkUFloat8), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkUFloat8? triggerManifoldTolerance;
		[HavokMember(EVersion.hk_2014_1_0_r1, 14, null, null, hkClassMember.Type.TYPE_HALF, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Half dynamicFriction;
		[HavokMember(EVersion.hk_2014_1_0_r1, 16, null, null, hkClassMember.Type.TYPE_HALF, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Half staticFriction;
		[HavokMember(EVersion.hk_2014_1_0_r1, 18, null, null, hkClassMember.Type.TYPE_HALF, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Half restitution;
		[HavokMember(EVersion.hk_2014_1_0_r1, 20, null, typeof(hknpMaterial.CombinePolicy), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpMaterial.CombinePolicy frictionCombinePolicy;
		[HavokMember(EVersion.hk_2014_1_0_r1, 21, null, typeof(hknpMaterial.CombinePolicy), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpMaterial.CombinePolicy restitutionCombinePolicy;
		[HavokMember(EVersion.hk_2014_1_0_r1, 22, null, null, hkClassMember.Type.TYPE_HALF, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Half weldingTolerance;
		[HavokMember(EVersion.hk_2014_1_0_r1, 24, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float maxContactImpulse;
		[HavokMember(EVersion.hk_2014_1_0_r1, 28, null, null, hkClassMember.Type.TYPE_REAL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private float fractionOfClippedImpulseToApply;
		[HavokMember(EVersion.hk_2014_1_0_r1, 32, null, typeof(hknpMaterial.MassChangerCategory), hkClassMember.Type.TYPE_ENUM, hkClassMember.Type.TYPE_UINT8, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpMaterial.MassChangerCategory massChangerCategory;
		[HavokMember(EVersion.hk_2014_1_0_r1, 34, null, null, hkClassMember.Type.TYPE_HALF, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Half massChangerHeavyObjectFactor;
		[HavokMember(EVersion.hk_2014_1_0_r1, 36, null, null, hkClassMember.Type.TYPE_HALF, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Half softContactForceFactor;
		[HavokMember(EVersion.hk_2014_1_0_r1, 38, null, null, hkClassMember.Type.TYPE_HALF, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Half softContactDampFactor;
		[HavokMember(EVersion.hk_2014_1_0_r1, 40, typeof(hkUFloat8), null, hkClassMember.Type.TYPE_STRUCT, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hkUFloat8? softContactSeperationVelocity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 44, typeof(hknpSurfaceVelocity), null, hkClassMember.Type.TYPE_POINTER, hkClassMember.Type.TYPE_STRUCT, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private hknpSurfaceVelocity? surfaceVelocity;
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, null, null, hkClassMember.Type.TYPE_HALF, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private Half disablingCollisionsBetweenCvxCvxDynamicObjectsDistance;
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, null, null, hkClassMember.Type.TYPE_UINT64, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.ALIGN_8)]
		private ulong userData;
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, null, null, hkClassMember.Type.TYPE_BOOL, hkClassMember.Type.TYPE_VOID, 0, hkClassMember.FlagValues.FLAGS_NONE)]
		private bool isShared;
	}
}
