using Server;

[RoutedMessage(XtCmd.UserDataVersion, QueueMessageMode.Never)]
public class UserDataVersionResponse : ServerMessage
{
	public readonly bool isDraining;

	public UserDataVersionResponse(INetMessageReader data)
	{
	}
}
