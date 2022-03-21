using Server;

public class TradeFailResponse : ServerMessage
{
	public readonly TradeValidationType tradeValidationType;

	public readonly string OtherUserUUID;

	public TradeFailResponse(INetMessageReader data)
	{
	}
}
