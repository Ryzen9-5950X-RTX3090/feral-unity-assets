using Server;

[RoutedMessage(XtCmd.FacilitatorDebugDisconnect, QueueMessageMode.Never)]
public class FacilitatorDebugDisconnect : ServerMessage
{
	public readonly bool success;

	public FacilitatorDebugDisconnect(INetMessageReader data)
	{
	}
}
