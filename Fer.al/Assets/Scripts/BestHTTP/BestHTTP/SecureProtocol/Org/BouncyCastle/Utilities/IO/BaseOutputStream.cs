using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO
{
	public abstract class BaseOutputStream : Stream
	{
		private bool closed;

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

		public override void Close()
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

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public virtual void Write(byte[] buffer)
		{
		}

		public override void WriteByte(byte b)
		{
		}
	}
}
