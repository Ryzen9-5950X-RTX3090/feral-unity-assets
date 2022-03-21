using Server;

public class TradeListUpdateResponse : ServerMessage
{
	public readonly string ItemId;

	public readonly bool IsInTradeList;

	public TradeListUpdateResponse(INetMessageReader data)
	{
	}
}
