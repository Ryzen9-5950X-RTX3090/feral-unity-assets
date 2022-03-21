using System.Collections.Generic;
using LitJson;
using Server;

public class InventoryListResponse : ServerMessage
{
	public readonly List<Item> Items;

	public readonly List<JsonData> ItemsJson;

	public InventoryListResponse(INetMessageReader data)
	{
	}

	public InventoryListResponse(List<Item> inItems)
	{
	}
}
