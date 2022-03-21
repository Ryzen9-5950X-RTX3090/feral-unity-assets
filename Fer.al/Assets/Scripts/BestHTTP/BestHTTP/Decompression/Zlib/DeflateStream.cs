using System.IO;

namespace BestHTTP.Decompression.Zlib
{
	public class DeflateStream : Stream
	{
		internal ZlibBaseStream _baseStream;

		internal Stream _innerStream;

		private bool _disposed;

		public virtual FlushType FlushMode
		{
			get
			{
				return default(FlushType);
			}
			set
			{
			}
		}

		public int BufferSize
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public CompressionStrategy Strategy
		{
			get
			{
				return default(CompressionStrategy);
			}
			set
			{
			}
		}

		public virtual long TotalIn
		{
			get
			{
				return default(long);
			}
		}

		public virtual long TotalOut
		{
			get
			{
				return default(long);
			}
		}

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

		public DeflateStream(Stream stream, CompressionMode mode)
		{
		}

		public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level)
		{
		}

		public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
		{
		}

		public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen, int windowBits)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override void Flush()
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
	}
}
