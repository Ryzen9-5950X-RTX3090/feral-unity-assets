using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public class ByteQueueStream : Stream
	{
		private readonly ByteQueue buffer;

		private byte[] writeByteBuffer;

		public virtual int Available
		{
			get
			{
				return default(int);
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

		public override void Flush()
		{
		}

		public virtual int Peek(byte[] buf)
		{
			return default(int);
		}

		public virtual int Read(byte[] buf)
		{
			return default(int);
		}

		public override int Read(byte[] buf, int off, int len)
		{
			return default(int);
		}

		public override int ReadByte()
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

		public virtual int Skip(int n)
		{
			return default(int);
		}

		public virtual void Write(byte[] buf)
		{
		}

		public override void Write(byte[] buf, int off, int len)
		{
		}

		public override void WriteByte(byte b)
		{
		}
	}
}
