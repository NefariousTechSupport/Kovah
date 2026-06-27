namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	public partial class hkbControlledReachModifier : hkbModifier
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ target;
		[HavokMember(EVersion.hk_2012_1_0_r1, 52, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private float time;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float fadeInStart;
		[HavokMember(EVersion.hk_2012_1_0_r1, 60, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float fadeInEnd;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float fadeOutStart;
		[HavokMember(EVersion.hk_2012_1_0_r1, 68, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float fadeOutEnd;
		[HavokMember(EVersion.hk_2012_1_0_r1, 72, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float fadeOutDuration;
		[HavokMember(EVersion.hk_2012_1_0_r1, 76, null, null, Type.TYPE_REAL, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private float sensorAngle;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, null, null, Type.TYPE_INT16, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private short handIndex;
		[HavokMember(EVersion.hk_2012_1_0_r1, 84, null, null, Type.TYPE_BOOL, Type.TYPE_VOID, 2, FlagValues.FLAGS_NONE)]
		private bool isHandEnabled;
	}
}
