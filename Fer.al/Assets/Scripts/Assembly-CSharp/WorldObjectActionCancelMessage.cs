using Server;

public class WorldObjectActionCancelMessage : ServerMessage, ITaggedMessage
{
	public readonly string ObjectId;

	public string GetTag()
	{
		return null;
	}

	public WorldObjectActionCancelMessage(INetMessageReader data)
	{
	}
}
