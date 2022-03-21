namespace BestHTTP.Decompression.Zlib
{
	internal sealed class InflateManager
	{
		private enum InflateManagerMode
		{
			METHOD,
			FLAG,
			DICT4,
			DICT3,
			DICT2,
			DICT1,
			DICT0,
			BLOCKS,
			CHECK4,
			CHECK3,
			CHECK2,
			CHECK1,
			DONE,
			BAD
		}

		private const int PRESET_DICT = 32;

		private const int Z_DEFLATED = 8;

		private InflateManagerMode mode;

		internal ZlibCodec _codec;

		internal int method;

		internal uint computedCheck;

		internal uint expectedCheck;

		internal int marker;

		private bool _handleRfc1950HeaderBytes;

		internal int wbits;

		internal InflateBlocks blocks;

		private static readonly byte[] mark;

		internal bool HandleRfc1950HeaderBytes
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public InflateManager()
		{
		}

		public InflateManager(bool expectRfc1950HeaderBytes)
		{
		}

		internal int Reset()
		{
			return default(int);
		}

		internal int End()
		{
			return default(int);
		}

		internal int Initialize(ZlibCodec codec, int w)
		{
			return default(int);
		}

		internal int Inflate(FlushType flush)
		{
			return default(int);
		}

		internal int SetDictionary(byte[] dictionary)
		{
			return default(int);
		}

		internal int Sync()
		{
			return default(int);
		}

		internal int SyncPoint(ZlibCodec z)
		{
			return default(int);
		}
	}
}
