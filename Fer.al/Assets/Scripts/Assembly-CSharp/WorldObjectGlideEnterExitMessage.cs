using Server;

public class WorldObjectGlideEnterExitMessage : ServerMessage, ITaggedMessage
{
	public readonly string UUID;

	public readonly int numPlayersInVolume;

	public string GetTag()
	{
		return null;
	}

	public WorldObjectGlideEnterExitMessage(INetMessageReader data)
	{
	}
}
