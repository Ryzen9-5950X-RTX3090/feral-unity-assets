namespace BestHTTP.Connections.HTTP2
{
	internal enum HTTP2FrameTypes : byte
	{
		DATA,
		HEADERS,
		PRIORITY,
		RST_STREAM,
		SETTINGS,
		PUSH_PROMISE,
		PING,
		GOAWAY,
		WINDOW_UPDATE,
		CONTINUATION,
		ALT_SVC
	}
}
