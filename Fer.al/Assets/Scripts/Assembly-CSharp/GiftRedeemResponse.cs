using Server;

[RoutedMessage(XtCmd.GiftRedeem, QueueMessageMode.Never)]
public class GiftRedeemResponse : ServerMessage
{
	public readonly string ItemId;

	public GiftRedeemResponse(INetMessageReader data)
	{
	}
}
