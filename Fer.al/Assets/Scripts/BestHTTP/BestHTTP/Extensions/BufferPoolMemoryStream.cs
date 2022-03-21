using System.IO;
using BestHTTP.PlatformSupport.Memory;

namespace BestHTTP.Extensions
{
	public sealed class BufferPoolMemoryStream : Stream
	{
		private bool canWrite;

		private bool allowGetBuffer;

		private int capacity;

		private int length;

		private byte[] internalBuffer;

		private int initialIndex;

		private bool expandable;

		private bool streamClosed;

		private int position;

		private int dirty_bytes;

		private bool releaseInternalBuffer;

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

		public int Capacity
		{
			get
			{
				return default(int);
			}
			set
			{
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

		public BufferPoolMemoryStream()
		{
		}

		public BufferPoolMemoryStream(int capacity)
		{
		}

		public BufferPoolMemoryStream(byte[] buffer)
		{
		}

		public BufferPoolMemoryStream(byte[] buffer, bool writable)
		{
		}

		public BufferPoolMemoryStream(byte[] buffer, int index, int count)
		{
		}

		public BufferPoolMemoryStream(byte[] buffer, int index, int count, bool writable)
		{
		}

		public BufferPoolMemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible)
		{
		}

		public BufferPoolMemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible, bool releaseBuffer)
		{
		}

		public BufferPoolMemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible, bool releaseBuffer, bool canExpand)
		{
		}

		private void InternalConstructor(byte[] buffer, int index, int count, bool writable, bool publicallyVisible, bool releaseBuffer, bool canExpand)
		{
		}

		private void CheckIfClosedThrowDisposed()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override void Flush()
		{
		}

		public byte[] GetBuffer()
		{
			return null;
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		public override int ReadByte()
		{
			return default(int);
		}

		public override long Seek(long offset, SeekOrigin loc)
		{
			return default(long);
		}

		private int CalculateNewCapacity(int minimum)
		{
			return default(int);
		}

		private void Expand(int newSize)
		{
		}

		public override void SetLength(long value)
		{
		}

		public byte[] ToArray()
		{
			return null;
		}

		public byte[] ToArray(bool canBeLarger)
		{
			return null;
		}

		public BufferSegment ToBufferSegment()
		{
			return default(BufferSegment);
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void WriteByte(byte value)
		{
		}

		public void WriteTo(Stream stream)
		{
		}
	}
}
