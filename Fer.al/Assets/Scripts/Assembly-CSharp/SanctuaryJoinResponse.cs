using Server;

[RoutedMessage(XtCmd.SanctuaryJoin, QueueMessageMode.Never)]
public class SanctuaryJoinResponse : ServerMessage
{
	public SanctuaryJoinResponse(INetMessageReader data)
	{
	}
}
