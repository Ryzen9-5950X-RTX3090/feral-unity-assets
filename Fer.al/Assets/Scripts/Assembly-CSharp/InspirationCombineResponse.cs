using Server;

[RoutedMessage(XtCmd.ItemInspirationCombine, QueueMessageMode.Never)]
public class InspirationCombineResponse : ServerMessage
{
	public enum Status
	{
		SUCCESS,
		ALREADY_OWNED,
		INVALID_COMBO
	}

	public readonly Status CombineStatus;

	public readonly string EnigmaDefId;

	public InspirationCombineResponse(INetMessageReader data)
	{
	}
}
