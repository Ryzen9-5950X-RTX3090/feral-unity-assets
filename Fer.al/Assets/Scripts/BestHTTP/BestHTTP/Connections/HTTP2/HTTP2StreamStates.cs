namespace BestHTTP.Connections.HTTP2
{
	internal enum HTTP2StreamStates
	{
		Idle,
		Open,
		HalfClosedLocal,
		HalfClosedRemote,
		Closed
	}
}
