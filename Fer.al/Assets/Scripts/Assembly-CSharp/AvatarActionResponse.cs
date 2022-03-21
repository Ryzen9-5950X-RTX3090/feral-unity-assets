using Server;

[RoutedMessage(XtCmd.AvatarAction, QueueMessageMode.Never)]
public class AvatarActionResponse : ServerMessage
{
	public readonly string actionDefId;

	public bool Success
	{
		get
		{
			return default(bool);
		}
	}

	public AvatarActionResponse(INetMessageReader data)
	{
	}
}
