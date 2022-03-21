using System.IO;

namespace ICSharpCode.SharpZipLib.Tar
{
	public class TarInputStream : Stream
	{
		public interface IEntryFactory
		{
			TarEntry CreateEntry(byte[] headerBuffer);
		}

		protected bool hasHitEOF;

		protected long entrySize;

		protected long entryOffset;

		protected byte[] readBuffer;

		protected TarBuffer tarBuffer;

		private TarEntry currentEntry;

		protected IEntryFactory entryFactory;

		private readonly Stream inputStream;

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

		public TarInputStream(Stream inputStream, int blockFactor)
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

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void WriteByte(byte value)
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

		public override void Close()
		{
		}

		public void Skip(long skipCount)
		{
		}

		public TarEntry GetNextEntry()
		{
			return null;
		}

		private void SkipToNextEntry()
		{
		}
	}
}
