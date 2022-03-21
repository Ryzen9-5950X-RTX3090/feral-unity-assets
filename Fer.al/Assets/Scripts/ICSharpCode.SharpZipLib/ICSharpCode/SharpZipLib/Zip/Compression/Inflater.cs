using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	public class Inflater
	{
		private static readonly int[] CPLENS;

		private static readonly int[] CPLEXT;

		private static readonly int[] CPDIST;

		private static readonly int[] CPDEXT;

		private int mode;

		private int readAdler;

		private int neededBits;

		private int repLength;

		private int repDist;

		private int uncomprLen;

		private bool isLastBlock;

		private long totalOut;

		private long totalIn;

		private bool noHeader;

		private StreamManipulator input;

		private OutputWindow outputWindow;

		private InflaterDynHeader dynHeader;

		private InflaterHuffmanTree litlenTree;

		private InflaterHuffmanTree distTree;

		private Adler32 adler;

		public bool IsNeedingInput
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsNeedingDictionary
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsFinished
		{
			get
			{
				return default(bool);
			}
		}

		public long TotalOut
		{
			get
			{
				return default(long);
			}
		}

		public int RemainingInput
		{
			get
			{
				return default(int);
			}
		}

		public Inflater(bool noHeader)
		{
		}

		public void Reset()
		{
		}

		private bool DecodeHeader()
		{
			return default(bool);
		}

		private bool DecodeDict()
		{
			return default(bool);
		}

		private bool DecodeHuffman()
		{
			return default(bool);
		}

		private bool DecodeChksum()
		{
			return default(bool);
		}

		private bool Decode()
		{
			return default(bool);
		}

		public void SetInput(byte[] buffer, int index, int count)
		{
		}

		public int Inflate(byte[] buffer, int offset, int count)
		{
			return default(int);
		}
	}
}
