namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbDockingGenerator : hkbGenerator
	{
		public enum BlendType
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			BLEND_TYPE_BLEND_IN,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			BLEND_TYPE_FULL_ON,
			
		}
		public enum DockingFlagBits
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 0)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 0)]
			FLAG_NONE,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 1)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 1)]
			FLAG_DOCK_TO_FUTURE_POSITION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, 2)]
			[HavokEnumItem(EVersion.hk_2014_1_0_r1, 2)]
			FLAG_OVERRIDE_MOTION,
			
		}
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private short dockingBone;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, Type.TYPE_VECTOR4, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Vector4 translationOffset;
		[HavokMember(EVersion.hk_2012_1_0_r1, 112, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 112, null, null, Type.TYPE_QUATERNION, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private Quaternion rotationOffset;
		[HavokMember(EVersion.hk_2012_1_0_r1, 128, null, typeof(hkbDockingGenerator.BlendType), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 128, null, typeof(hkbDockingGenerator.BlendType), Type.TYPE_ENUM, Type.TYPE_INT8, 0, FlagValues.FLAGS_NONE)]
		private hkbDockingGenerator.BlendType blendType;
		[HavokMember(EVersion.hk_2012_1_0_r1, 130, null, typeof(hkbDockingGenerator.DockingFlagBits), Type.TYPE_FLAGS, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 130, null, typeof(hkbDockingGenerator.DockingFlagBits), Type.TYPE_FLAGS, Type.TYPE_UINT16, 0, FlagValues.FLAGS_NONE)]
		private hkbDockingGenerator.DockingFlagBits flags;
		[HavokMember(EVersion.hk_2012_1_0_r1, 132, typeof(hkbGenerator), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 132, typeof(hkbGenerator), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbGenerator? child;
		[HavokMember(EVersion.hk_2012_1_0_r1, 136, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 136, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int intervalStart;
		[HavokMember(EVersion.hk_2012_1_0_r1, 140, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 140, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int intervalEnd;
		[HavokMember(EVersion.hk_2012_1_0_r1, 144, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 144, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private float localTime;
		[HavokMember(EVersion.hk_2012_1_0_r1, 148, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 148, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private float previousLocalTime;
		[HavokMember(EVersion.hk_2012_1_0_r1, 152, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 152, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private float intervalStartLocalTime;
		[HavokMember(EVersion.hk_2012_1_0_r1, 156, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 156, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private float intervalEndLocalTime;
	}
}
