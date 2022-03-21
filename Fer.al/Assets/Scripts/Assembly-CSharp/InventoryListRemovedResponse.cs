using System.Collections.Generic;
using Server;

public class InventoryListRemovedResponse : ServerMessage
{
	public readonly string[] RemovedItemIds;

	public InventoryListRemovedResponse(INetMessageReader data)
	{
	}

	public InventoryListRemovedResponse(List<Item> inItems)
	{
	}
}
