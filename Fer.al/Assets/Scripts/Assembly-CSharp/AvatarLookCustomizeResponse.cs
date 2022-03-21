using Server;

[RoutedMessage(XtCmd.AvatarLookCustomize, QueueMessageMode.Never)]
public class AvatarLookCustomizeResponse : ServerMessage
{
	public readonly string ItemId;

	public bool Success
	{
		get
		{
			return default(bool);
		}
	}

	public AvatarLookCustomizeResponse(INetMessageReader data)
	{
	}
}
