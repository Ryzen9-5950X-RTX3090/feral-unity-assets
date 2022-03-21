using Server;

public class TradeInitiateResponse : ServerMessage
{
	public readonly TradeValidationType tradeValidationType;

	public string userId;

	public bool Success
	{
		get
		{
			return default(bool);
		}
	}

	public TradeInitiateResponse(INetMessageReader data)
	{
	}
}
