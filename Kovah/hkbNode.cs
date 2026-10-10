namespace Kovah
{
	public partial class hkbNode : hkbBindable
	{
		public ulong UserData
		{
			get => userData;
			set => userData = value;
		}
		public string? Name
		{
			get => name;
			set => name = value;
		}
		public ushort Id
		{
			get => id;
			set => id = value;
		}
		public sbyte _CloneState
		{
			get => cloneState;
			set => cloneState = value;
		}
		public byte Type
		{
			get => type;
			set => type = value;
		}
		public object? NodeInfo
		{
			get => nodeInfo;
			set => nodeInfo = value;
		}
	}
}
