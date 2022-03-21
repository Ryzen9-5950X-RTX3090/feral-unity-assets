using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib
{
	public class ZOutputStream : Stream
	{
		private const int BufferSize = 4096;

		protected ZStream z;

		protected int flushLevel;

		protected byte[] buf;

		protected byte[] buf1;

		protected bool compress;

		protected Stream output;

		protected bool closed;

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

		public ZOutputStream(Stream output)
		{
		}

		public ZOutputStream(Stream output, bool nowrap)
		{
		}

		public ZOutputStream(Stream output, ZStream z)
		{
		}

		public ZOutputStream(Stream output, int level)
		{
		}

		public ZOutputStream(Stream output, int level, bool nowrap)
		{
		}

		public override void Close()
		{
		}

		private void DoClose()
		{
		}

		public virtual void End()
		{
		}

		public virtual void Finish()
		{
		}

		public override void Flush()
		{
		}

		public sealed override int Read(byte[] buffer, int offset, int count)
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

		public override void Write(byte[] b, int off, int len)
		{
		}

		public override void WriteByte(byte b)
		{
		}
	}
}
