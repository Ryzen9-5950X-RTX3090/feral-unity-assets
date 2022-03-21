public interface ISeasonPassTier
{
	string DefId { get; }

	int TierNumber { get; }

	bool IsFree { get; }

	int Progress { get; }

	float NormalizedProgress { get; }

	bool IsCompleted { get; }

	bool IsCurrent { get; }

	int TotalRequiredAuraPoints { get; }

	int LocalRequiredAuraPoints { get; }

	int UnlockCost { get; }

	BundlePackDefComponent.CraftableItemsEntry Reward { get; }
}
