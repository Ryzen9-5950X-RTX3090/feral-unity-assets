using Server;

public class TradeAddRemoveItemResponse : ServerMessage
{
	public bool Success;

	public string UserId;

	public bool IsAdding;

	public Item UpdatedItem;

	public int Quantity;

	public TradeAddRemoveItemResponse(INetMessageReader data)
	{
	}
}
