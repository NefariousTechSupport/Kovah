namespace Kovah
{
	public partial class hkbProjectData
	{
		public Vector4 WorldUpWS
		{
			get => worldUpWS;
			set => worldUpWS = value;
		}

		public hkbProjectStringData? StringData
		{
			get => stringData;
			set => stringData = value;
		}

		public hkbTransitionEffect.EventMode DefaultEventMode
		{
			get => defaultEventMode;
			set => defaultEventMode = value;
		}
	}
}