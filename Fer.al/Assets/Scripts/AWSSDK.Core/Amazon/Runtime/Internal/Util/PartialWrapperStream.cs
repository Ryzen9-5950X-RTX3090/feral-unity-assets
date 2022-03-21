using System.IO;

namespace Amazon.Runtime.Internal.Util
{
	public class PartialWrapperStream : WrapperStream
	{
		private long initialPosition;

		private long partSize;

		private long RemainingPartSize
		{
			get
			{
				return default(long);
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

		public PartialWrapperStream(Stream stream, long partSize)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
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

		public override void WriteByte(byte value)
		{
		}
	}
}
