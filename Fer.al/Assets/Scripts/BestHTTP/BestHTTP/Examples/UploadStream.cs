using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace BestHTTP.Examples
{
	public sealed class UploadStream : Stream
	{
		private MemoryStream ReadBuffer;

		private MemoryStream WriteBuffer;

		private bool noMoreData;

		private AutoResetEvent ARE;

		private object locker;

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private bool IsReadBufferEmpty
		{
			get
			{
				return default(bool);
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

		public UploadStream(string name)
		{
		}

		public UploadStream()
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

		protected override void Dispose(bool disposing)
		{
		}

		public void Finish()
		{
		}

		private bool SwitchBuffers()
		{
			return default(bool);
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
