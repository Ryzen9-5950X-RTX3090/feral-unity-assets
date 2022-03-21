using System;
using System.IO;

namespace Amazon.Runtime.Internal.Util
{
	public class ReadOnlyWrapperStream : WrapperStream
	{
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

		public ReadOnlyWrapperStream(Stream baseStream)
		{
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void SetLength(long value)
		{
		}

		public override void Flush()
		{
		}
	}
}
