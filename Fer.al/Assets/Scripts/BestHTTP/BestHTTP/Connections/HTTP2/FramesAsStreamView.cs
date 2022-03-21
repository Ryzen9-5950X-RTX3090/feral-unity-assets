using System.IO;

namespace BestHTTP.Connections.HTTP2
{
	internal sealed class FramesAsStreamView : Stream
	{
		private IFrameDataView view;

		public override bool CanRead
		{
			get
			{
				return default(bool);
			}
		}

		public override bool CanSeek
		{
			get
			{
				return default(bool);
			}
		}

		public override bool CanWrite
		{
			get
			{
				return default(bool);
			}
		}

		public override long Length
		{
			get
			{
				return default(long);
			}
		}

		public override long Position
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public FramesAsStreamView(IFrameDataView view)
		{
		}

		public void AddFrame(HTTP2FrameHeaderAndPayload frame)
		{
		}

		public override int ReadByte()
		{
			return default(int);
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		public override void Close()
		{
		}

		public override void Flush()
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		public override void SetLength(long value)
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
