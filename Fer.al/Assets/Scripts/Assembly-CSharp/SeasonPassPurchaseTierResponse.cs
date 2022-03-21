using Server;

[RoutedMessage(XtCmd.SeasonPassPurchaseTier, QueueMessageMode.Never)]
public class SeasonPassPurchaseTierResponse : ServerMessage
{
	public readonly bool Success;

	public SeasonPassPurchaseTierResponse(INetMessageReader data)
	{
	}
}
