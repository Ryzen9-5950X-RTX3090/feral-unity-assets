using System;
using System.IO;
using System.Text;

namespace BestHTTP.Decompression.Zlib
{
	public class GZipStream : Stream
	{
		public DateTime? LastModified;

		private int _headerByteCount;

		internal ZlibBaseStream _baseStream;

		private bool _disposed;

		private bool _firstReadDone;

		private string _FileName;

		private string _Comment;

		private int _Crc32;

		internal static readonly DateTime _unixEpoch;

		internal static readonly Encoding iso8859dash1;

		public string Comment
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string FileName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Crc32
		{
			get
			{
				return default(int);
			}
		}

		public virtual FlushType FlushMode
		{
			get
			{
				return default(FlushType);
			}
			set
			{
			}
		}

		public int BufferSize
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public virtual long TotalIn
		{
			get
			{
				return default(long);
			}
		}

		public virtual long TotalOut
		{
			get
			{
				return default(long);
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

		public GZipStream(Stream stream, CompressionMode mode)
		{
		}

		public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level)
		{
		}

		public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
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

		private int EmitHeader()
		{
			return default(int);
		}
	}
}
