namespace Kovah
{
	[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
	public sealed class HavokEnumItemAttribute : Attribute
	{
		private EVersion version;
		private int value;

		public HavokEnumItemAttribute(EVersion version, int value)
		{
			this.version = version;
			this.value   = value;
		}
		
		public EVersion Version => version;
		public int Value => value;
	}
}