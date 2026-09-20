using System.Reflection;
using Kovah.Packfile;
using Sapphire;

namespace Kovah
{
	public class HavokClassSerialization
	{
		private Type type;
		private HavokClassSerialization? parent;
		private uint objectSize;
		private uint alignment;
		private List<HavokMemberSerialization> members;
		private List<HavokMemberSerialization>? membersInclBase;
		private bool computed;


		public Type DotNetType => type;
		public HavokClassSerialization? Parent => parent;
		public uint ObjectSize => objectSize;
		public uint Alignment => alignment;
		public IReadOnlyList<HavokMemberSerialization> Members => GetMembers();


		public HavokClassSerialization(HavokPackfile file, Type type)
		{
			this.type = type;
			this.parent = file.GetClassSerialization(type.BaseType);
			this.objectSize = 1;
			this.members = new List<HavokMemberSerialization>();
			this.membersInclBase = null;
			this.computed = false;


			FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

			for (int f = 0; f < fields.Length; f++)
			{
				IEnumerable<HavokMemberAttribute> attrs = fields[f].GetCustomAttributes<HavokMemberAttribute>();

				foreach(HavokMemberAttribute attr in attrs)
				{
					if (attr.Version == file.metadataVersion)
					{
						HavokMemberSerialization member = new HavokMemberSerialization(attr, fields[f]);
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


			members = members.OrderBy(x => x.Ordinal).ToList();
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

			if (type == typeof(hkBaseObject))
			{
				objectSize = file.pointerSize;
				alignment  = file.pointerSize;
				return;
			}

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


		private void GetMembers(List<HavokMemberSerialization> list)
		{
			if (parent != null)
			{
				parent.GetMembers(list);
			}

			list.AddRange(members);
		}


		public List<HavokMemberSerialization> GetMembers()
		{
			if (membersInclBase == null)
			{
				membersInclBase = new List<HavokMemberSerialization>();
				GetMembers(membersInclBase);
			}

			return membersInclBase;
		}
	}
}