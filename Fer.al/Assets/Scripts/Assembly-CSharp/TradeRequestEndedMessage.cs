public class TradeRequestEndedMessage : TradeMessage
{
	public enum Reason
	{
		Cancelled,
		Rejected,
		Timeout,
		UserNotAvailable
	}

	public readonly Reason reason;

	public TradeRequestEndedMessage(Trade inTrade, Reason inReason)
	{
	}
}
