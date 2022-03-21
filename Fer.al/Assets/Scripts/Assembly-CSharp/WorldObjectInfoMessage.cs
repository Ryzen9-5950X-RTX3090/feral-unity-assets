using Server;

[RoutedMessage(XtCmd.WorldObjectInfo, QueueMessageMode.Never)]
public class WorldObjectInfoMessage : ServerMessage
{
	public readonly string Id;

	public readonly string DefId;

	public readonly string OwnerId;

	public readonly WorldObjectMoveNodeData LastMove;

	public WorldObjectInfoMessage(INetMessageReader data)
	{
	}
}
