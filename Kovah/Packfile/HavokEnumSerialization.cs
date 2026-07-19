using System.Reflection;

namespace Kovah.Packfile
{
	public struct HavokEnumSerialization
	{
		public Type type;
		private List<string> names;
		private List<int> serialValues;
		private List<int> realValues;


		public HavokEnumSerialization(HavokPackfile file, Type type)
		{
			this.type = type;
			this.names = new List<string>();
			this.serialValues = new List<int>();
			this.realValues = new List<int>();


			string[] names  = Enum.GetNames(type);
			Array values = Enum.GetValues(type);

			for (int i = 0; i < names.Length; i++)
			{
				foreach (HavokEnumItemAttribute attr in type.GetField(names[i])!.GetCustomAttributes<HavokEnumItemAttribute>())
				{
					if (attr.Version == file.metadataVersion)
					{
						this.names.Add(names[i]);
						this.serialValues.Add(attr.Value);
						this.realValues.Add((int)values.GetValue(i)!);
						break;
					}
				}
			}
		}


		public object? DeserializeEnum(int value)
		{
			bool isFlags = type.GetCustomAttribute<FlagsAttribute>() != null;

			int intValue = 0;

			for (int i = 0; i < serialValues.Count; i++)
			{
				if (isFlags)
				{
					bool match = (value & serialValues[i]) != 0;
					if (match)
					{
						intValue |= realValues[i];
					}
				}
				else
				{
					bool match = value == serialValues[i];
					if (match)
					{
						intValue = realValues[i];
						break;
					}
				}
			}

			return Enum.ToObject(type, intValue);
		}
	}
}