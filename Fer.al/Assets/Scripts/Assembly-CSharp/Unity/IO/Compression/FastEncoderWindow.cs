namespace Unity.IO.Compression
{
	internal class FastEncoderWindow
	{
		private byte[] window;

		private int bufPos;

		private int bufEnd;

		private const int FastEncoderHashShift = 4;

		private const int FastEncoderHashtableSize = 2048;

		private const int FastEncoderHashMask = 2047;

		private const int FastEncoderWindowSize = 8192;

		private const int FastEncoderWindowMask = 8191;

		private const int FastEncoderMatch3DistThreshold = 16384;

		internal const int MaxMatch = 258;

		internal const int MinMatch = 3;

		private const int SearchDepth = 32;

		private const int GoodLength = 4;

		private const int NiceLength = 32;

		private const int LazyMatchThreshold = 6;

		private ushort[] prev;

		private ushort[] lookup;

		public int BytesAvailable
		{
			get
			{
				return default(int);
			}
		}

		public DeflateInput UnprocessedInput
		{
			get
			{
				return null;
			}
		}

		public int FreeWindowSpace
		{
			get
			{
				return default(int);
			}
		}

		public void FlushWindow()
		{
		}

		private void ResetWindow()
		{
		}

		public void CopyBytes(byte[] inputBuffer, int startIndex, int count)
		{
		}

		public void MoveWindows()
		{
		}

		private uint HashValue(uint hash, byte b)
		{
			return default(uint);
		}

		private uint InsertString(ref uint hash)
		{
			return default(uint);
		}

		private void InsertStrings(ref uint hash, int matchLen)
		{
		}

		internal bool GetNextSymbolOrMatch(Match match)
		{
			return default(bool);
		}

		private int FindMatch(int search, out int matchPos, int searchDepth, int niceLength)
		{
			return default(int);
		}

		private uint RecalculateHash(int position)
		{
			return default(uint);
		}
	}
}
