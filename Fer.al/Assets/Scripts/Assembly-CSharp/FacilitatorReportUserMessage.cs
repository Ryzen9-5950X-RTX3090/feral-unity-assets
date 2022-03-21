using Server;

[RoutedMessage(XtCmd.FacilitatorReport, QueueMessageMode.Never)]
public class FacilitatorReportUserMessage : ServerMessage
{
	public readonly bool success;

	public FacilitatorReportUserMessage(INetMessageReader data)
	{
	}
}
