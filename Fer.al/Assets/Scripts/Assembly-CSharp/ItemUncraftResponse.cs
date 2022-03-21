using Server;

[RoutedMessage(XtCmd.ItemUncraft, QueueMessageMode.Never)]
public class ItemUncraftResponse : ServerMessage
{
	public readonly bool Success;

	public readonly string ItemId;

	public ItemUncraftResponse(INetMessageReader data)
	{
	}
}
