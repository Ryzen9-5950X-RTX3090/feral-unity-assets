using Server;

[RoutedMessage(XtCmd.FacilitatorSetBusy, QueueMessageMode.Never)]
public class FacilitatorSetBusyMessage : ServerMessage
{
	public readonly bool success;

	public FacilitatorSetBusyMessage(INetMessageReader data)
	{
	}
}
