public interface IPlayerLevel
{
	int LevelNumber { get; }

	int TotalXP { get; }

	int CurrentXP { get; }

	int RequiredXP { get; }

	float NormalizedProgress { get; }
}
