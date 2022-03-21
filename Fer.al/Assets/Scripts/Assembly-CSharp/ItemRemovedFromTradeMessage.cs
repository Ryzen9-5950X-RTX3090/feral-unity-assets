public class ItemRemovedFromTradeMessage : TradeMessage
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

	public ItemRemovedFromTradeMessage(Trade inTrade, Item inItem, string inItemOwnerUUID)
	{
	}
}
