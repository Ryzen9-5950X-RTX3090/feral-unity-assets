using System.IO;

namespace ThirdParty.Ionic.Zlib
{
	public class CrcCalculatorStream : Stream
	{
		private Stream _InnerStream;

		private CRC32 _Crc32;

		private long _length;

		public long TotalBytesSlurped
		{
			get
			{
				return default(long);
			}
		}

		public int Crc32
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

		public CrcCalculatorStream(Stream stream)
		{
		}

		public CrcCalculatorStream(Stream stream, long length)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		public override void Write(byte[] buffer, int offset, int count)
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
	}
}
