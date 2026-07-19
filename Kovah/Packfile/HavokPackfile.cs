namespace Kovah.Packfile
{
	public class HavokPackfile
	{
		public const uint kMagicCookie1 = 0x57E0E057;
		public const uint kMagicCookie2 = 0x10C0C010;


		private static readonly (string name, EVersion version)[] kVersionLookup =
		{
			("Havok-7.1.0-r1",          EVersion.Havok_7_1_0_r1),
			("hk_2011.2.0-r1",          EVersion.hk_2011_2_0_r1),
			("hk_2012.1.0-r1",          EVersion.hk_2012_1_0_r1),
			("hk_2013.1.0-r1",          EVersion.hk_2013_1_0_r1),
			("hk_2014.1.0-r1",          EVersion.hk_2014_1_0_r1),
		};


		public uint userTag;
		public uint version;
		public byte pointerSize;
		public bool reusePadding;
		public bool emptyBaseClassOptimisation;
		public uint contentSectionIndex;
		public uint contentSectionOffset;
		public uint contentClassNameSectionIndex;
		public uint contentClassNameSectionOffset;
		public EVersion metadataVersion;
		public uint flags;
		public ushort maxPredicate;
		public byte[]? predicates;

		public List<HavokClassSerialization> classes = new List<HavokClassSerialization>();
		public Dictionary<Type, HavokEnumSerialization> enums = new Dictionary<Type, HavokEnumSerialization>();


		public HavokClassSerialization? GetClassSerialization(Type? clazz)
		{
			if (clazz == typeof(object))
			{
				return null;
			}

			HavokClassSerialization? classSerialization = null;
			if (clazz != null)
			{
				classSerialization = classes.FirstOrDefault(x => x.type == clazz);
				if (classSerialization == null)
				{
					classSerialization = new HavokClassSerialization(this, clazz);
					classes.Add(classSerialization);
					classSerialization.ComputeOffsets(this);
				}
			}
			return classSerialization;
		}


		public static EVersion? GetVersionEnum(string name)
		{
			for (int v = 0; v < kVersionLookup.Length; v++)
			{
				if (kVersionLookup[v].name == name)
				{
					return kVersionLookup[v].version;
				}
			}

			return null;
		}


		public static string? GetVersionName(EVersion version)
		{
			for (int v = 0; v < kVersionLookup.Length; v++)
			{
				if (kVersionLookup[v].version == version)
				{
					return kVersionLookup[v].name;
				}
			}

			return null;
		}	}
}