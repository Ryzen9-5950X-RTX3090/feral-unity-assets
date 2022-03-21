public class TradeConfirmationUpdatedMessage : TradeMessage
{
	public readonly bool? IsAcceptedByMe;

	public readonly bool? IsAcceptedByThem;

	public TradeConfirmationUpdatedMessage(Trade inTrade, bool? inIsAcceptedByMe, bool? inIsAcceptedByThem)
	{
	}
}
