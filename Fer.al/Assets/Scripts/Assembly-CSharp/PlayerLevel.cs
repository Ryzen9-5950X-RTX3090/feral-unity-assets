using System.Runtime.CompilerServices;

public struct PlayerLevel : IPlayerLevel
{
	public int LevelNumber
	{
		[IsReadOnly]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int TotalXP
	{
		[IsReadOnly]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int CurrentXP
	{
		[IsReadOnly]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int RequiredXP
	{
		[IsReadOnly]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float NormalizedProgress
	{
		get
		{
			return default(float);
		}
	}

	public PlayerLevel(int inCurrentLevel, int inTotalXP, int inCurrentXP, int inRequiredXP)
	{
	}

	public PlayerLevel(XPUpdateServerMessage.CurrentLevel inLevelFromServer, int inTotalXP)
	{
	}
}
