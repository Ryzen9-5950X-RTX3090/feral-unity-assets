namespace BestHTTP.Connections.HTTP2
{
	internal struct HTTP2PriorityFrame
	{
		public readonly HTTP2FrameHeaderAndPayload Header;

		public byte IsExclusive;

		public uint StreamDependency;

		public byte Weight;

		public HTTP2PriorityFrame(HTTP2FrameHeaderAndPayload header)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
