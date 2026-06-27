namespace Kovah
{
	[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = true)]
	public sealed class HavokMemberAttribute : Attribute
	{
		private EVersion version;
		private ushort offset;
		private Type? clazz;
		private Type? eenum;
		private hkClassMember.Type type;
		private hkClassMember.Type subtype;
		private ushort cArraySize;
		private hkClassMember.FlagValues flags;
		public HavokMemberAttribute(EVersion version, ushort offset, Type? clazz, Type? eenum, hkClassMember.Type type, hkClassMember.Type subtype, ushort cArraySize, hkClassMember.FlagValues flags)
		{
			this.version    = version;
			this.offset     = offset;
			this.clazz      = clazz;
			this.eenum      = eenum;
			this.type       = type;
			this.subtype    = subtype;
			this.cArraySize = cArraySize;
			this.flags      = flags;
		}

		public EVersion Version               => version;
		public ushort Offset                  => offset;
		public Type? Class                    => clazz;
		public Type? Enum                     => eenum;
		public hkClassMember.Type Type        => type;
		public hkClassMember.Type Subtype     => subtype;
		public ushort ArraySize               => cArraySize;
		public hkClassMember.FlagValues Flags => flags;
	}
}