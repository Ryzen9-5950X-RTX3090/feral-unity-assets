using System.Runtime.CompilerServices;

public class TestSeasonPassTier : ISeasonPassTier
{
	[CompilerGenerated]
	private readonly string <DefId>k__BackingField;

	[CompilerGenerated]
	private readonly int <TierNumber>k__BackingField;

	[CompilerGenerated]
	private readonly bool <IsFree>k__BackingField;

	[CompilerGenerated]
	private readonly int <TotalRequiredAuraPoints>k__BackingField;

	[CompilerGenerated]
	private readonly int <LocalRequiredAuraPoints>k__BackingField;

	[CompilerGenerated]
	private readonly int <UnlockCost>k__BackingField;

	[CompilerGenerated]
	private readonly BundlePackDefComponent.CraftableItemsEntry <Reward>k__BackingField;

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
		[CompilerGenerated]
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

	public int TotalRequiredAuraPoints
	{
		[CompilerGenerated]
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
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	public BundlePackDefComponent.CraftableItemsEntry Reward
	{
		[CompilerGenerated]
		get
		{
			return null;
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

	public TestSeasonPassTier(int inTierNumber, bool inIsFree, BundlePackDefComponent.CraftableItemsEntry inReward, int inPriorRequiredPoints, ISeasonPass inSeasonPass)
	{
	}
}
