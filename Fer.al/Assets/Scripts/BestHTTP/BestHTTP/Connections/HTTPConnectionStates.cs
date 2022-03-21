namespace BestHTTP.Connections
{
	public enum HTTPConnectionStates
	{
		Initial,
		Processing,
		WaitForProtocolShutdown,
		Recycle,
		Free,
		Closed,
		ClosedResendRequest
	}
}
