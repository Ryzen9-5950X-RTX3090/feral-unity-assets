using Server;

public class AvatarLookSwitchResponse : ServerMessage
{
	public readonly string ItemId;

	public bool Success
	{
		get
		{
			return default(bool);
		}
	}

	public AvatarLookSwitchResponse(INetMessageReader data)
	{
	}
}
