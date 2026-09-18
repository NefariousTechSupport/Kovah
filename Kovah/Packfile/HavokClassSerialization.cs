using System.Reflection;
using Kovah.Packfile;
using Sapphire;

namespace Kovah
{
	public class HavokClassSerialization
	{
		public Type type;
		public HavokClassSerialization? parent;
		public uint objectSize;
		public uint alignment;
		public List<HavokMemberSerialization> members;
		private bool computed;


		public HavokClassSerialization(HavokPackfile file, Type type)
		{
			this.type = type;
			this.parent = file.GetClassSerialization(type.BaseType);
			this.objectSize = 1;
			this.members = new List<HavokMemberSerialization>();
			this.computed = false;


			FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

			for (int f = 0; f < fields.Length; f++)
			{
				IEnumerable<HavokMemberAttribute> attrs = fields[f].GetCustomAttributes<HavokMemberAttribute>();

				foreach(HavokMemberAttribute attr in attrs)
				{
					if (attr.Version == file.metadataVersion)
					{
						HavokMemberSerialization member = new HavokMemberSerialization();
						member.offset = 0;
						member.attr = attr;
						member.field = fields[f];
						members.Add(member);

						if (attr.Enum != null)
						{
							if (!file.enums.ContainsKey(attr.Enum))
							{
								file.enums.Add(attr.Enum, new HavokEnumSerialization(file, attr.Enum));
							}
						}
						break;
					}
				}
			}


			members = members.OrderBy(x => x.attr.Offset).ToList();
		}


		private uint GetNextFieldStart(HavokPackfile file)
		{
			if (members.Count > 0)
			{
				return members.Last().offset + members.Last().GetSize(file);
			}

			if (parent != null)
			{
				return parent.GetNextFieldStart(file);
			}

			return file.emptyBaseClassOptimisation ? 0u : 1u;
		}


		public void ComputeOffsets(HavokPackfile file)
		{
			if (computed)
			{
				return;
			}
			computed = true;

			uint head = 0;
			uint workingAlignment = 0;

			if (parent != null)
			{
				parent.ComputeOffsets(file);
				head = parent.objectSize;
				workingAlignment = parent.alignment;
			}

			if (file.reusePadding)
			{
				head = GetNextFieldStart(file);
			}

			for (int m = 0; m < members.Count; m++)
			{
				HavokMemberSerialization member = members[m];
				member.offset = StreamHelper.Align(head, member.GetAlignment(file));
				workingAlignment = Math.Max(workingAlignment, member.GetAlignment(file));
				head += member.GetSize(file);
				members[m] = member;
			}

			objectSize = StreamHelper.Align(Math.Max(1, head), workingAlignment);
			alignment = Math.Max(1, workingAlignment);
		}
	}
}