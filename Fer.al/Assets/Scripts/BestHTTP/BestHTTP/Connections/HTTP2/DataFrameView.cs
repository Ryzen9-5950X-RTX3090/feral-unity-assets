namespace BestHTTP.Connections.HTTP2
{
	internal sealed class DataFrameView : CommonFrameView
	{
		public override void AddFrame(HTTP2FrameHeaderAndPayload frame)
		{
		}

		protected override long CalculateDataLengthForFrame(HTTP2FrameHeaderAndPayload frame)
		{
			return default(long);
		}

		protected override bool AdvanceFrame()
		{
			return default(bool);
		}
	}
}
