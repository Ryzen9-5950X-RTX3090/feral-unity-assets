using Server;

[RoutedMessage(XtCmd.WorldObjectDelete, QueueMessageMode.Never)]
public class WorldObjectDeleteMessage : ServerMessage, ITaggedMessage
{
	public readonly string ObjectId;

	public string GetTag()
	{
		return null;
	}

	public WorldObjectDeleteMessage(INetMessageReader data)
	{
	}
}
