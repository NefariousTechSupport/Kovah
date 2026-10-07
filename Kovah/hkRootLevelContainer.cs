using System.Diagnostics;
using System.Runtime.Serialization;

namespace Kovah
{
	public partial class hkRootLevelContainer
	{
		public uint GetNumVariants()
		{
			return namedVariants == null ? 0u : (uint)namedVariants.Length;
		}

		public hkRootLevelContainerNamedVariant GetNamedVariant(uint index)
		{
			if (namedVariants == null)
			{
				throw new IndexOutOfRangeException();
			}

			hkRootLevelContainerNamedVariant? variant = namedVariants[index];
			Debug.Assert(variant != null);

			return variant;
		}

		public void SetNamedVariant(uint index, hkRootLevelContainerNamedVariant variant)
		{
			if (variant == null)
			{
				throw new ArgumentNullException(nameof(variant));
			}
			if (namedVariants == null)
			{
				throw new IndexOutOfRangeException();
			}

			namedVariants[index] = variant;
		}

		public void AddNamedVariant(hkRootLevelContainerNamedVariant variant)
		{
			if (variant == null)
			{
				throw new ArgumentNullException(nameof(variant));
			}

			int desiredCapacity = 1;

			if (namedVariants != null)
			{
				desiredCapacity = namedVariants.Length + 1;
			}

			hkRootLevelContainerNamedVariant?[] variants = new hkRootLevelContainerNamedVariant?[desiredCapacity];
			if (namedVariants != null)
			{
				Array.Copy(namedVariants, variants, namedVariants.Length);
			}

			variants[desiredCapacity - 1] = variant;
			namedVariants = variants;
		}

		public bool TryRemoveNamedVariant(hkRootLevelContainerNamedVariant variant)
		{
			if (variant == null)
			{
				throw new ArgumentNullException(nameof(variant));
			}
			if (namedVariants == null)
			{
				return false;
			}

			int index = Array.IndexOf(namedVariants, variant);
			if (index < 0)
			{
				return false;
			}

			return TryRemoveNamedVariant((uint)index);
		}

		public bool TryRemoveNamedVariant(uint index)
		{
			if (namedVariants == null)
			{
				return false;
			}

			if (index >= namedVariants.Length)
			{
				return false;
			}

			hkRootLevelContainerNamedVariant?[] variants = new hkRootLevelContainerNamedVariant?[namedVariants.Length - 1];
			Array.Copy(namedVariants, 0, variants, 0, index);
			Array.Copy(namedVariants, index + 1, variants, index, namedVariants.Length - index - 1);

			namedVariants = variants;
			return true;
		}
	}
}