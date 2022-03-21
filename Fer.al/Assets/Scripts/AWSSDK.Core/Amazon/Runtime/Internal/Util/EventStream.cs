using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Amazon.Runtime.Internal.Util
{
	internal class EventStream : WrapperStream
	{
		internal delegate void ReadProgress(int bytesRead);

		private class AsyncResult : IAsyncResult
		{
			public object AsyncState
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public WaitHandle AsyncWaitHandle
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public bool CompletedSynchronously
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public bool IsCompleted
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			internal object Return
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		private bool disableClose;

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

		public override int ReadTimeout
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public override int WriteTimeout
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		internal event ReadProgress OnRead
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal EventStream(Stream stream, bool disableClose)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override void Flush()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
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

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void WriteByte(byte value)
		{
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override void Close()
		{
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return default(int);
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
		}
	}
}
