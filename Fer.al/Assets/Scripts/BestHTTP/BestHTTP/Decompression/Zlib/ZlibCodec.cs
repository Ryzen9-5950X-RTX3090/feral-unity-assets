namespace BestHTTP.Decompression.Zlib
{
	internal sealed class ZlibCodec
	{
		public byte[] InputBuffer;

		public int NextIn;

		public int AvailableBytesIn;

		public long TotalBytesIn;

		public byte[] OutputBuffer;

		public int NextOut;

		public int AvailableBytesOut;

		public long TotalBytesOut;

		public string Message;

		internal DeflateManager dstate;

		internal InflateManager istate;

		internal uint _Adler32;

		public CompressionLevel CompressLevel;

		public int WindowBits;

		public CompressionStrategy Strategy;

		public int Adler32
		{
			get
			{
				return default(int);
			}
		}

		public ZlibCodec()
		{
		}

		public ZlibCodec(CompressionMode mode)
		{
		}

		public int InitializeInflate()
		{
			return default(int);
		}

		public int InitializeInflate(bool expectRfc1950Header)
		{
			return default(int);
		}

		public int InitializeInflate(int windowBits)
		{
			return default(int);
		}

		public int InitializeInflate(int windowBits, bool expectRfc1950Header)
		{
			return default(int);
		}

		public int Inflate(FlushType flush)
		{
			return default(int);
		}

		public int EndInflate()
		{
			return default(int);
		}

		public int SyncInflate()
		{
			return default(int);
		}

		public int InitializeDeflate()
		{
			return default(int);
		}

		public int InitializeDeflate(CompressionLevel level)
		{
			return default(int);
		}

		public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header)
		{
			return default(int);
		}

		public int InitializeDeflate(CompressionLevel level, int bits)
		{
			return default(int);
		}

		public int InitializeDeflate(CompressionLevel level, int bits, bool wantRfc1950Header)
		{
			return default(int);
		}

		private int _InternalInitializeDeflate(bool wantRfc1950Header)
		{
			return default(int);
		}

		public int Deflate(FlushType flush)
		{
			return default(int);
		}

		public int EndDeflate()
		{
			return default(int);
		}

		public void ResetDeflate()
		{
		}

		public int SetDeflateParams(CompressionLevel level, CompressionStrategy strategy)
		{
			return default(int);
		}

		public int SetDictionary(byte[] dictionary)
		{
			return default(int);
		}

		internal void flush_pending()
		{
		}

		internal int read_buf(byte[] buf, int start, int size)
		{
			return default(int);
		}
	}
}
