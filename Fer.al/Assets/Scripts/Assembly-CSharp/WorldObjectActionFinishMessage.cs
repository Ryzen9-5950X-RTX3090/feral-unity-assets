using Server;

public class WorldObjectActionFinishMessage : ServerMessage, ITaggedMessage
{
	public readonly string ObjectId;

	public readonly InteractableState interactableState;

	public string GetTag()
	{
		return null;
	}

	public WorldObjectActionFinishMessage(INetMessageReader data)
	{
	}
}
