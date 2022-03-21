using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Amazon.Runtime.Internal.Util
{
	public class CachingWrapperStream : WrapperStream
	{
		private readonly int? _cacheLimit;

		private int _cachedBytes;

		public List<byte> AllReadBytes
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

		public List<byte> LoggableReadBytes
		{
			get
			{
				return null;
			}
		}

		public override bool CanSeek
		{
			get
			{
				return default(bool);
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

		public CachingWrapperStream(Stream baseStream, [Optional] int? cacheLimit)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		private void UpdateCacheAfterReading(byte[] buffer, int offset, int numberOfBytesRead)
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}
	}
}
