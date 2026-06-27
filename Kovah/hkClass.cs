using System.Reflection;

namespace Kovah
{
	public partial class hkClass
	{
		public static Type? LookupClass(EVersion version, string name)
		{
			Type? result = Type.GetType($"Kovah.{name}");

			if (result != null)
			{
				IEnumerable<HavokClassAttribute> classAttrs = result.GetCustomAttributes<HavokClassAttribute>(false);
				foreach (HavokClassAttribute attr in classAttrs)
				{
					// the version must match
					if (attr.Version == version)
					{
						return result;
					}
				}
			}

			return null;
		}
	}
}