using Server;

public class WorldObjectActionStartMessage : ServerMessage, ITaggedMessage
{
	public readonly string ObjectId;

	public readonly string userUUID;

	public string GetTag()
	{
		return null;
	}

	public WorldObjectActionStartMessage(INetMessageReader data)
	{
	}
}
