namespace Kovah
{
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkbAttachmentModifier : hkbModifier
	{
		[HavokMember(EVersion.hk_2012_1_0_r1, 48, typeof(hkbEventProperty), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 48, typeof(hkbEventProperty), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbEventProperty? sendToAttacherOnAttach;
		[HavokMember(EVersion.hk_2012_1_0_r1, 56, typeof(hkbEventProperty), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 56, typeof(hkbEventProperty), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbEventProperty? sendToAttacheeOnAttach;
		[HavokMember(EVersion.hk_2012_1_0_r1, 64, typeof(hkbEventProperty), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 64, typeof(hkbEventProperty), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbEventProperty? sendToAttacherOnDetach;
		[HavokMember(EVersion.hk_2012_1_0_r1, 72, typeof(hkbEventProperty), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 72, typeof(hkbEventProperty), null, Type.TYPE_STRUCT, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private hkbEventProperty? sendToAttacheeOnDetach;
		[HavokMember(EVersion.hk_2012_1_0_r1, 80, typeof(hkbAttachmentSetup), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 80, typeof(hkbAttachmentSetup), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbAttachmentSetup? attachmentSetup;
		[HavokMember(EVersion.hk_2012_1_0_r1, 84, typeof(hkbHandle), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 84, typeof(hkbHandle), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbHandle? attacherHandle;
		[HavokMember(EVersion.hk_2012_1_0_r1, 88, typeof(hkbHandle), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 88, typeof(hkbHandle), null, Type.TYPE_POINTER, Type.TYPE_STRUCT, 0, FlagValues.FLAGS_NONE)]
		private hkbHandle? attacheeHandle;
		[HavokMember(EVersion.hk_2012_1_0_r1, 92, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 92, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.FLAGS_NONE)]
		private int attacheeLayer;
		[HavokMember(EVersion.hk_2012_1_0_r1, 96, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 96, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ attacheeRB;
		[HavokMember(EVersion.hk_2012_1_0_r1, 100, null, null, Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 100, null, null, Type.TYPE_ENUM, Type.TYPE_UINT8, 0, FlagValues.SERIALIZE_IGNORED)]
		private byte oldMotionType;
		[HavokMember(EVersion.hk_2012_1_0_r1, 104, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 104, null, null, Type.TYPE_INT32, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private int oldFilterInfo;
		[HavokMember(EVersion.hk_2012_1_0_r1, 108, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		[HavokMember(EVersion.hk_2014_1_0_r1, 108, null, null, Type.TYPE_POINTER, Type.TYPE_VOID, 0, FlagValues.SERIALIZE_IGNORED)]
		private object? /* void */ attachment;
	}
}
