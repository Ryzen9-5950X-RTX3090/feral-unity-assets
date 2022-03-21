using System;
using System.IO;
using BestHTTP.Decompression.Crc;

namespace BestHTTP.Decompression.Zlib
{
	internal class ZlibBaseStream : Stream
	{
		internal enum StreamMode
		{
			Writer,
			Reader,
			Undefined
		}

		protected internal ZlibCodec _z;

		protected internal StreamMode _streamMode;

		protected internal FlushType _flushMode;

		protected internal ZlibStreamFlavor _flavor;

		protected internal CompressionMode _compressionMode;

		protected internal CompressionLevel _level;

		protected internal bool _leaveOpen;

		protected internal byte[] _workingBuffer;

		protected internal int _bufferSize;

		protected internal int windowBitsMax;

		protected internal byte[] _buf1;

		protected internal Stream _stream;

		protected internal CompressionStrategy Strategy;

		private CRC32 crc;

		protected internal string _GzipFileName;

		protected internal string _GzipComment;

		protected internal DateTime _GzipMtime;

		protected internal int _gzipHeaderByteCount;

		private bool nomoreinput;

		internal int Crc32
		{
			get
			{
				return default(int);
			}
		}

		protected internal bool _wantCompress
		{
			get
			{
				return default(bool);
			}
		}

		private ZlibCodec z
		{
			get
			{
				return null;
			}
		}

		private byte[] workingBuffer
		{
			get
			{
				return null;
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

		public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen)
		{
		}

		public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen, int windowBits)
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		private void finish()
		{
		}

		private void end()
		{
		}

		public override void Close()
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

		private string ReadZeroTerminatedString()
		{
			return null;
		}

		private int _ReadAndValidateGzipHeader()
		{
			return default(int);
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}
	}
}
