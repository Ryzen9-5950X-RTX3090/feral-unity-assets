using Server;

[RoutedMessage(XtCmd.AvatarLookGet, QueueMessageMode.Never)]
public class AvatarLookGetResponse : ServerMessage
{
	public readonly AvatarLookItemComponent avatarLookItemComponent;

	public AvatarLookGetResponse(INetMessageReader data)
	{
	}
}
