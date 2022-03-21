using System.Runtime.CompilerServices;

public class SeasonPassTier : ISeasonPassTier
{
	[CompilerGenerated]
	private readonly string <DefId>k__BackingField;

	[CompilerGenerated]
	private readonly int <TierNumber>k__BackingField;

	[CompilerGenerated]
	private readonly int <LocalRequiredAuraPoints>k__BackingField;

	private SeasonPassTierDefComponent _tierDef;

	private ISeasonPass _seasonPass;

	public string DefId
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public int TierNumber
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	public bool IsFree
	{
		get
		{
			return default(bool);
		}
	}

	public int Progress
	{
		get
		{
			return default(int);
		}
	}

	public float NormalizedProgress
	{
		get
		{
			return default(float);
		}
	}

	public bool IsCompleted
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsCurrent
	{
		get
		{
			return default(bool);
		}
	}

	public int TotalRequiredAuraPoints
	{
		get
		{
			return default(int);
		}
	}

	public int LocalRequiredAuraPoints
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	public int UnlockCost
	{
		get
		{
			return default(int);
		}
	}

	public BundlePackDefComponent.CraftableItemsEntry Reward
	{
		get
		{
			return null;
		}
	}

	public SeasonPassTier(string inDefId, int inTierNumber, ISeasonPass inSeasonPass)
	{
	}
}
