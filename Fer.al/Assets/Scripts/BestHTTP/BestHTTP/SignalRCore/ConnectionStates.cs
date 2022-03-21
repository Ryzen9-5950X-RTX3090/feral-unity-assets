namespace BestHTTP.SignalRCore
{
	public enum ConnectionStates
	{
		Initial,
		Authenticating,
		Negotiating,
		Redirected,
		Reconnecting,
		Connected,
		CloseInitiated,
		Closed
	}
}
