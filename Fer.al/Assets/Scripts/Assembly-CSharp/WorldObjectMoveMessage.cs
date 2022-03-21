using Server;

public class WorldObjectMoveMessage : ServerMessage, ITaggedMessage
{
	public readonly string ObjectId;

	public readonly WorldObjectMoveNodeData Node;

	public string GetTag()
	{
		return null;
	}

	public WorldObjectMoveMessage(WorldObjectMoveNodeData inNode, INetMessageReader data)
	{
	}

	public WorldObjectMoveMessage(INetMessageReader data)
	{
	}
}
