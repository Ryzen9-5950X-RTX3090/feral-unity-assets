namespace BestHTTP.Connections.HTTP2
{
	internal enum HTTP2ErrorCodes
	{
		NO_ERROR,
		PROTOCOL_ERROR,
		INTERNAL_ERROR,
		FLOW_CONTROL_ERROR,
		SETTINGS_TIMEOUT,
		STREAM_CLOSED,
		FRAME_SIZE_ERROR,
		REFUSED_STREAM,
		CANCEL,
		COMPRESSION_ERROR,
		CONNECT_ERROR,
		ENHANCE_YOUR_CALM,
		INADEQUATE_SECURITY,
		HTTP_1_1_REQUIRED
	}
}