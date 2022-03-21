using System.IO;

namespace BestHTTP.Extensions
{
	public sealed class ReadOnlyBufferedStream : Stream
	{
		private Stream stream;

		public const int READBUFFER = 8192;

		private byte[] buf;

		private int available;

		private int pos;

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

		public ReadOnlyBufferedStream(Stream nstream)
		{
		}

		public ReadOnlyBufferedStream(Stream nstream, int bufferSize)
		{
		}

		public override int Read(byte[] buffer, int offset, int size)
		{
			return default(int);
		}

		public override int ReadByte()
		{
			return default(int);
		}

		protected override void Dispose(bool disposing)
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
	}
}
