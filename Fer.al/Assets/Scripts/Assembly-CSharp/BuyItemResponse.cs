using Server;

[RoutedMessage(XtCmd.ShopBuyItem, QueueMessageMode.Never)]
public class BuyItemResponse : ServerMessage
{
	public readonly PurchaseResult Result;

	public readonly string[] ItemIds;

	public readonly string[] RareItemIds;

	public readonly int PurchaseCount;

	public readonly int RareItemCount;

	public bool Success
	{
		get
		{
			return default(bool);
		}
	}

	public BuyItemResponse(INetMessageReader data)
	{
	}
}
