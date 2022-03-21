using Server;

public class InventoryItemRemovedResponse : ServerMessage
{
	public readonly string RemovedItemId;

	public InventoryItemRemovedResponse(INetMessageReader data)
	{
	}

	public InventoryItemRemovedResponse(Item inItem)
	{
	}
}
