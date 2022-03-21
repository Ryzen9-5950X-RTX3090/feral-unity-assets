using System;

namespace BestHTTP.WebSocket.Frames
{
	public struct RawFrameData : IDisposable
	{
		public byte[] Data;

		public int Length;

		public RawFrameData(byte[] data, int length)
		{
		}

		public void Dispose()
		{
		}
	}
}
