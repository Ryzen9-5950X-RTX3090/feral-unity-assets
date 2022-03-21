using System.IO;

namespace Amazon.Runtime.Internal.Util
{
	public class PartialReadOnlyWrapperStream : ReadOnlyWrapperStream
	{
		private long _currentPosition;

		private long _size;

		private long RemainingSize
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
		}

		public PartialReadOnlyWrapperStream(Stream baseStream, long size)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}
	}
}
