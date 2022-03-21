using System.Collections.Generic;
using Server;

public class TradeReadyAcceptResponse : ServerMessage
{
	public bool Success;

	public bool WaitingOnOtherPlayer;

	public Dictionary<string, string> AddedItems;

	public TradeReadyAcceptResponse(INetMessageReader data)
	{
	}
}
