namespace BestHTTP.Decompression.Zlib
{
	internal sealed class InflateBlocks
	{
		private enum InflateBlockMode
		{
			TYPE,
			LENS,
			STORED,
			TABLE,
			BTREE,
			DTREE,
			CODES,
			DRY,
			DONE,
			BAD
		}

		private const int MANY = 1440;

		internal static readonly int[] border;

		private InflateBlockMode mode;

		internal int left;

		internal int table;

		internal int index;

		internal int[] blens;

		internal int[] bb;

		internal int[] tb;

		internal InflateCodes codes;

		internal int last;

		internal ZlibCodec _codec;

		internal int bitk;

		internal int bitb;

		internal int[] hufts;

		internal byte[] window;

		internal int end;

		internal int readAt;

		internal int writeAt;

		internal object checkfn;

		internal uint check;

		internal InfTree inftree;

		internal InflateBlocks(ZlibCodec codec, object checkfn, int w)
		{
		}

		internal uint Reset()
		{
			return default(uint);
		}

		internal int Process(int r)
		{
			return default(int);
		}

		internal void Free()
		{
		}

		internal void SetDictionary(byte[] d, int start, int n)
		{
		}

		internal int SyncPoint()
		{
			return default(int);
		}

		internal int Flush(int r)
		{
			return default(int);
		}
	}
}
