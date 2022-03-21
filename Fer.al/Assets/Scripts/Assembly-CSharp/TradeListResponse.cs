using System.Collections.Generic;
using Server;

public class TradeListResponse : ServerMessage
{
	public readonly List<Item> Items;

	public TradeListResponse(INetMessageReader data)
	{
	}
}
