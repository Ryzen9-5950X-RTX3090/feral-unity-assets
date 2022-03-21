using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO
{
	public class SignerStream : Stream
	{
		protected readonly Stream stream;

		protected readonly ISigner inSigner;

		protected readonly ISigner outSigner;

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

		public SignerStream(Stream stream, ISigner readSigner, ISigner writeSigner)
		{
		}

		public virtual ISigner ReadSigner()
		{
			return null;
		}

		public virtual ISigner WriteSigner()
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
