using System;
using System.IO;

namespace Unity.IO.Compression
{
	public class GZipStream : Stream
	{
		private DeflateStream deflateStream;

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

		public Stream BaseStream
		{
			get
			{
				return null;
			}
		}

		public GZipStream(Stream stream, CompressionMode mode)
		{
		}

		public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		private void SetDeflateStreamFileFormatter(CompressionMode mode)
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

		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return default(int);
		}

		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		public override int Read(byte[] array, int offset, int count)
		{
			return default(int);
		}

		public override void Write(byte[] array, int offset, int count)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
