using Server;

[RoutedMessage(XtCmd.SeasonPassChallengeComplete, QueueMessageMode.Never)]
public class SeasonPassChallengeCompleteResponse : ServerMessage
{
	public readonly int auraPointsAwarded;

	public readonly string challengeUUID;

	public readonly string defId;

	public readonly bool hasNewChallenge;

	public readonly string newChallengeUUID;

	public readonly string newChallengeDefId;

	public SeasonPassChallengeCompleteResponse(INetMessageReader data)
	{
	}
}
