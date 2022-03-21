public class UserReadyStateChangedMessage : TradeMessage
{
	public readonly bool IsReady;

	public readonly string UserUUID;

	public bool UserIsMe
	{
		get
		{
			return default(bool);
		}
	}

	public UserReadyStateChangedMessage(Trade inTrade, bool inIsReady, string inUserUUID)
	{
	}
}
