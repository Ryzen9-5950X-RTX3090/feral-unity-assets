using Server;

[RoutedMessage(XtCmd.LoginComplete, QueueMessageMode.Never)]
public class LoginCompleteResponse : ServerMessage
{
	public LoginCompleteResponse(INetMessageReader data)
	{
	}
}
