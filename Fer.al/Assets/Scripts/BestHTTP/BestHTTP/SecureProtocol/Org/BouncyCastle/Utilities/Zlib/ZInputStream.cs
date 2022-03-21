using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib
{
	public class ZInputStream : Stream
	{
		private const int BufferSize = 4096;

		protected ZStream z;

		protected int flushLevel;

		protected byte[] buf;

		protected byte[] buf1;

		protected bool compress;

		protected Stream input;

		protected bool closed;

		private bool nomoreinput;

		public sealed override bool CanRead
		{
			get
			{
				return default(bool);
			}
		}

		public sealed override bool CanSeek
		{
			get
			{
				return default(bool);
			}
		}

		public sealed override bool CanWrite
		{
			get
			{
				return default(bool);
			}
		}

		public virtual int FlushMode
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public sealed override long Length
		{
			get
			{
				return default(long);
			}
		}

		public sealed override long Position
		{
			get
			{
				return default(long);
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

		private static ZStream GetDefaultZStream(bool nowrap)
		{
			return null;
		}

		public ZInputStream(Stream input)
		{
		}

		public ZInputStream(Stream input, bool nowrap)
		{
		}

		public ZInputStream(Stream input, ZStream z)
		{
		}

		public ZInputStream(Stream input, int level)
		{
		}

		public ZInputStream(Stream input, int level, bool nowrap)
		{
		}

		public override void Close()
		{
		}

		public sealed override void Flush()
		{
		}

		public override int Read(byte[] b, int off, int len)
		{
			return default(int);
		}

		public override int ReadByte()
		{
			return default(int);
		}

		public sealed override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		public sealed override void SetLength(long value)
		{
		}

		public sealed override void Write(byte[] buffer, int offset, int count)
		{
		}
	}
}
