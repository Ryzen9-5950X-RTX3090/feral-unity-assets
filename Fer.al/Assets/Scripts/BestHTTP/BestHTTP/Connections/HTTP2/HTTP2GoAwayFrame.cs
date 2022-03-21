namespace BestHTTP.Connections.HTTP2
{
	internal struct HTTP2GoAwayFrame
	{
		public readonly HTTP2FrameHeaderAndPayload Header;

		public byte ReservedBit;

		public uint LastStreamId;

		public uint ErrorCode;

		public byte[] AdditionalDebugData;

		public uint AdditionalDebugDataLength;

		public HTTP2ErrorCodes Error
		{
			get
			{
				return default(HTTP2ErrorCodes);
			}
		}

		public HTTP2GoAwayFrame(HTTP2FrameHeaderAndPayload header)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
