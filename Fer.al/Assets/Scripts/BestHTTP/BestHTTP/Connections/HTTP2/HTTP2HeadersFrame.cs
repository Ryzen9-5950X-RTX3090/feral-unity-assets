namespace BestHTTP.Connections.HTTP2
{
	internal struct HTTP2HeadersFrame
	{
		public readonly HTTP2FrameHeaderAndPayload Header;

		public byte? PadLength;

		public byte? IsExclusive;

		public uint? StreamDependency;

		public byte? Weight;

		public uint HeaderBlockFragmentIdx;

		public byte[] HeaderBlockFragment;

		public uint HeaderBlockFragmentLength;

		public HTTP2HeadersFlags Flags
		{
			get
			{
				return default(HTTP2HeadersFlags);
			}
		}

		public HTTP2HeadersFrame(HTTP2FrameHeaderAndPayload header)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
