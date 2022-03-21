using Server;

[RoutedMessage(XtCmd.ShopBuyBundle, QueueMessageMode.Never)]
public class BuyBundleResponse : ServerMessage
{
	public readonly PurchaseResult Status;

	public BuyBundleResponse(INetMessageReader data)
	{
	}
}
