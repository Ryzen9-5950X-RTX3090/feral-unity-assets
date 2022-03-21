namespace BestHTTP.Connections.HTTP2
{
	internal struct HTTP2PingFrame
	{
		public readonly HTTP2FrameHeaderAndPayload Header;

		public readonly byte[] OpaqueData;

		public readonly byte OpaqueDataLength;

		public HTTP2PingFlags Flags
		{
			get
			{
				return default(HTTP2PingFlags);
			}
		}

		public HTTP2PingFrame(HTTP2FrameHeaderAndPayload header)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
