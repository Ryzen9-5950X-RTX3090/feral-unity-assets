namespace BestHTTP.Connections.HTTP2
{
	internal struct HTTP2AltSVCFrame
	{
		public readonly HTTP2FrameHeaderAndPayload Header;

		public string Origin;

		public string AltSvcFieldValue;

		public HTTP2AltSVCFrame(HTTP2FrameHeaderAndPayload header)
		{
		}
	}
}
