using System.Runtime.CompilerServices;

public class SeasonPassChallenge : ISeasonPassChallenge
{
	[CompilerGenerated]
	private readonly string <DefId>k__BackingField;

	private int _progress;

	[CompilerGenerated]
	private readonly int <Requirement>k__BackingField;

	[CompilerGenerated]
	private readonly int <AuraPoints>k__BackingField;

	private SeasonPassChallengeDefComponent _challengeDef;

	public string DefId
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public string LocalizedName
	{
		get
		{
			return null;
		}
	}

	public int Progress
	{
		get
		{
			return default(int);
		}
		set
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

	public int Requirement
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	public bool IsCompleted
	{
		get
		{
			return default(bool);
		}
	}

	public int AuraPoints
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	public SeasonPassChallenge(string inDefId, int inProgress)
	{
	}

	public void SetState(int inProgress)
	{
	}
}
