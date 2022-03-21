namespace BestHTTP.Connections.HTTP2
{
	internal struct HTTP2DataFrame
	{
		public readonly HTTP2FrameHeaderAndPayload Header;

		public byte? PadLength;

		public uint DataIdx;

		public byte[] Data;

		public uint DataLength;

		public HTTP2DataFlags Flags
		{
			get
			{
				return default(HTTP2DataFlags);
			}
		}

		public HTTP2DataFrame(HTTP2FrameHeaderAndPayload header)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
