using Server;

[RoutedMessage(XtCmd.ItemCraft, QueueMessageMode.Never)]
public class ItemCraftResponse : ServerMessage
{
	public readonly string ItemId;

	public ItemCraftResponse(INetMessageReader data)
	{
	}
}
