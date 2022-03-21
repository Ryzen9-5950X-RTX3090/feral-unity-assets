using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	internal class ZipHelperStream : Stream
	{
		private bool isOwner_;

		private Stream stream_;

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

		public override bool CanTimeout
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

		public override bool CanWrite
		{
			get
			{
				return default(bool);
			}
		}

		public ZipHelperStream(Stream stream)
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

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void Close()
		{
		}

		public long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData)
		{
			return default(long);
		}

		public int ReadLEShort()
		{
			return default(int);
		}

		public int ReadLEInt()
		{
			return default(int);
		}
	}
}
