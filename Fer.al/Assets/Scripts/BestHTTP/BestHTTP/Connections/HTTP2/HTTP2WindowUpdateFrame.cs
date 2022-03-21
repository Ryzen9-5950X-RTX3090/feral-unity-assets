namespace BestHTTP.Connections.HTTP2
{
	internal struct HTTP2WindowUpdateFrame
	{
		public readonly HTTP2FrameHeaderAndPayload Header;

		public byte ReservedBit;

		public uint WindowSizeIncrement;

		public HTTP2WindowUpdateFrame(HTTP2FrameHeaderAndPayload header)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
