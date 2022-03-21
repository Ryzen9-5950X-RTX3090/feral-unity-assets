using Server;

public class WorldObjectActionMessage : ServerMessage, ITaggedMessage
{
	public readonly string ObjectId;

	public readonly string ActionDefId;

	public string GetTag()
	{
		return null;
	}

	public WorldObjectActionMessage(INetMessageReader data)
	{
	}
}
