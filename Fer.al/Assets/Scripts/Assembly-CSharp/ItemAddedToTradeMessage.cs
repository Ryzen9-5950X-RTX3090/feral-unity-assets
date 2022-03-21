public class ItemAddedToTradeMessage : TradeMessage
{
	public readonly Item Item;

	public readonly string ItemOwnerUUID;

	public bool ItemOwnerIsMe
	{
		get
		{
			return default(bool);
		}
	}

	public ItemAddedToTradeMessage(Trade inTrade, Item inItem, string inItemOwnerUUID)
	{
	}
}
