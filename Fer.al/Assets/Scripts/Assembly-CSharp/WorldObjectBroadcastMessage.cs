using Server;

[RoutedMessage(XtCmd.WorldObjectBroadcast, QueueMessageMode.Never)]
public class WorldObjectBroadcastMessage : ServerMessage, ITaggedMessage
{
	public readonly string SubCmd;

	public readonly string ObjectId;

	public readonly string QuestDefId;

	public string GetTag()
	{
		return null;
	}

	public WorldObjectBroadcastMessage(INetMessageReader data)
	{
	}
}
