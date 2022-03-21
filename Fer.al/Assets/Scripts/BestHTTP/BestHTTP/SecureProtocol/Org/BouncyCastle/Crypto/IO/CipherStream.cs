using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO
{
	public class CipherStream : Stream
	{
		internal Stream stream;

		internal IBufferedCipher inCipher;

		internal IBufferedCipher outCipher;

		private byte[] mInBuf;

		private int mInPos;

		private bool inStreamEnded;

		public IBufferedCipher ReadCipher
		{
			get
			{
				return null;
			}
		}

		public IBufferedCipher WriteCipher
		{
			get
			{
				return null;
			}
		}

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

		public CipherStream(Stream stream, IBufferedCipher readCipher, IBufferedCipher writeCipher)
		{
		}

		public override int ReadByte()
		{
			return default(int);
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		private bool FillInBuf()
		{
			return default(bool);
		}

		private byte[] ReadAndProcessBlock()
		{
			return null;
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

		public sealed override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		public sealed override void SetLength(long length)
		{
		}
	}
}
