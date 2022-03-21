using Server;

[RoutedMessage(XtCmd.SeasonPassChallengeUpdate, QueueMessageMode.Never)]
public class SeasonPassChallengeUpdateResponse : ServerMessage
{
	public readonly int progressCount;

	public readonly string challengeUUID;

	public readonly string defId;

	public readonly int requiredCount;

	public SeasonPassChallengeUpdateResponse(INetMessageReader data)
	{
	}
}
