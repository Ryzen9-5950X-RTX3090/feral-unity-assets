public interface ISeasonPassChallenge
{
	string DefId { get; }

	string LocalizedName { get; }

	int Progress { get; set; }

	float NormalizedProgress { get; }

	int Requirement { get; }

	bool IsCompleted { get; }

	int AuraPoints { get; }
}
