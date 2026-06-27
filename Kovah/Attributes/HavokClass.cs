namespace Kovah
{
	[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
	public sealed class HavokClassAttribute : Attribute
	{
		private EVersion version;
		public HavokClassAttribute(EVersion version)
		{
			this.version = version;
		}
		
		public EVersion Version => version;
	}
}