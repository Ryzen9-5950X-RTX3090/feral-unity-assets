using Server;

public class FacilitatorDisconnectResponse : ServerMessage
{
	private int _enumValue;

	public DisconnectReason Reason;

	public FacilitatorDisconnectResponse(XtReader data)
	{
	}
}
