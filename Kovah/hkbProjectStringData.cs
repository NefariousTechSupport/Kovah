namespace Kovah
{
	public partial class hkbProjectStringData
	{
		public string?[]? AnimationFilenames
		{
			get => animationFilenames;
			set => animationFilenames = value;
		}

		public string?[]? BehaviorFilenames
		{
			get => behaviorFilenames;
			set => behaviorFilenames = value;
		}

		public string?[]? CharacterFilenames
		{
			get => characterFilenames;
			set => characterFilenames = value;
		}

		public string?[]? EventNames
		{
			get => eventNames;
			set => eventNames = value;
		}

		public string? AnimationPath
		{
			get => animationPath;
			set => animationPath = value;
		}

		public string? BehaviorPath
		{
			get => behaviorPath;
			set => behaviorPath = value;
		}

		public string? CharacterPath
		{
			get => characterPath;
			set => characterPath = value;
		}

		public string? ScriptsPath
		{
			get => scriptsPath;
			set => scriptsPath = value;
		}

		public string? FullPathToSource
		{
			get => fullPathToSource;
			set => fullPathToSource = value;
		}

		public string? RootPath
		{
			get => rootPath;
			set => rootPath = value;
		}
	}
}