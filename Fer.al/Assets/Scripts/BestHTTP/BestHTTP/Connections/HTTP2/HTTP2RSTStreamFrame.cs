namespace BestHTTP.Connections.HTTP2
{
	internal struct HTTP2RSTStreamFrame
	{
		public readonly HTTP2FrameHeaderAndPayload Header;

		public uint ErrorCode;

		public HTTP2ErrorCodes Error
		{
			get
			{
				return default(HTTP2ErrorCodes);
			}
		}

		public HTTP2RSTStreamFrame(HTTP2FrameHeaderAndPayload header)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
