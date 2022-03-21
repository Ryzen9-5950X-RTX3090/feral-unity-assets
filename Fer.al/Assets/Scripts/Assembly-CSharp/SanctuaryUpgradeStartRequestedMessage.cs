public class SanctuaryUpgradeStartRequestedMessage : Message
{
	public readonly int stage;

	public readonly int[] enlargedAreaIndexes;

	public SanctuaryUpgradeStartRequestedMessage(int stage, int[] enlargedAreaIndexes)
	{
	}
}
