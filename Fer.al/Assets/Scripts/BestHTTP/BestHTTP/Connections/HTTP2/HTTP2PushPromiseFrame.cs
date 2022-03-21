namespace BestHTTP.Connections.HTTP2
{
	internal struct HTTP2PushPromiseFrame
	{
		public readonly HTTP2FrameHeaderAndPayload Header;

		public byte? PadLength;

		public byte ReservedBit;

		public uint PromisedStreamId;

		public uint HeaderBlockFragmentIdx;

		public byte[] HeaderBlockFragment;

		public uint HeaderBlockFragmentLength;

		public HTTP2PushPromiseFlags Flags
		{
			get
			{
				return default(HTTP2PushPromiseFlags);
			}
		}

		public HTTP2PushPromiseFrame(HTTP2FrameHeaderAndPayload header)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
