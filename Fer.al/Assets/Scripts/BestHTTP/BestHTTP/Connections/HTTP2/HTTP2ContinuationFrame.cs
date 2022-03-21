namespace BestHTTP.Connections.HTTP2
{
	internal struct HTTP2ContinuationFrame
	{
		public readonly HTTP2FrameHeaderAndPayload Header;

		public byte[] HeaderBlockFragment;

		public HTTP2ContinuationFlags Flags
		{
			get
			{
				return default(HTTP2ContinuationFlags);
			}
		}

		public uint HeaderBlockFragmentLength
		{
			get
			{
				return default(uint);
			}
		}

		public HTTP2ContinuationFrame(HTTP2FrameHeaderAndPayload header)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
