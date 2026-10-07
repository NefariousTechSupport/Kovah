namespace Kovah
{
	public partial class hkRootLevelContainerNamedVariant
	{
		public string? Name
		{
			get => name;
			set => name = value;
		}

		public string? ClassName
		{
			get => className;
			set => className = value;
		}

		public hkReferencedObject? Variant
		{
			get => variant;
			set => variant = value;
		}


		public hkRootLevelContainerNamedVariant(string name, string className, hkReferencedObject variant)
		{
			this.name      = name;
			this.className = className;
			this.variant   = variant;
		}
	}
}