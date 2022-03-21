using Server;

public class TradeReadyResponse : ServerMessage
{
	public bool Success;

	public string UserId;

	public bool IsReady;

	public TradeReadyResponse(INetMessageReader data)
	{
	}
}
