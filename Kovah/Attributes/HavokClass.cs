namespace Kovah
{
	[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
	public sealed class HavokClassAttribute : Attribute
	{
		private EVersion version;
		private Type? parent;
		public HavokClassAttribute(EVersion version, Type? parent)
		{
			this.version = version;
			this.parent = parent;
		}
		
		public EVersion Version => version;
		public Type? Parent => parent;
	}
}