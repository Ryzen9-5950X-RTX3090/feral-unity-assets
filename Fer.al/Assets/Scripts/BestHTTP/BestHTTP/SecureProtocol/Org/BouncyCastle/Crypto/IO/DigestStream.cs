using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO
{
	public class DigestStream : Stream
	{
		protected readonly Stream stream;

		protected readonly IDigest inDigest;

		protected readonly IDigest outDigest;

		public override bool CanRead
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

		public override bool CanSeek
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

		public DigestStream(Stream stream, IDigest readDigest, IDigest writeDigest)
		{
		}

		public virtual IDigest ReadDigest()
		{
			return null;
		}

		public virtual IDigest WriteDigest()
		{
			return null;
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		public override int ReadByte()
		{
			return default(int);
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void WriteByte(byte b)
		{
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

		public override void SetLength(long length)
		{
		}
	}
}
