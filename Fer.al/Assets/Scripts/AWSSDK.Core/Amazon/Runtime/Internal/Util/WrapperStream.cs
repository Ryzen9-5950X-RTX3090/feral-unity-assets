using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal.Util
{
	public class WrapperStream : Stream
	{
		protected Stream BaseStream
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

		internal virtual bool HasLength
		{
			get
			{
				return default(bool);
			}
		}

		public WrapperStream(Stream baseStream)
		{
		}

		public Stream GetNonWrapperBaseStream()
		{
			return null;
		}

		public Stream GetSeekableBaseStream()
		{
			return null;
		}

		public static Stream GetNonWrapperBaseStream(Stream stream)
		{
			return null;
		}

		public Stream SearchWrappedStream(Func<Stream, bool> condition)
		{
			return null;
		}

		public static Stream SearchWrappedStream(Stream stream, Func<Stream, bool> condition)
		{
			return null;
		}

		public override void Close()
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
	}
}
