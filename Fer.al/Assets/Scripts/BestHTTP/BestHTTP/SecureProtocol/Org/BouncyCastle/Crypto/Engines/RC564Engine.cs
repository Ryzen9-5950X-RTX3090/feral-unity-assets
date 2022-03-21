namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class RC564Engine : IBlockCipher
	{
		private static readonly int wordSize;

		private static readonly int bytesPerWord;

		private int _noRounds;

		private long[] _S;

		private static readonly long P64;

		private static readonly long Q64;

		private bool forEncryption;

		public virtual string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return default(bool);
			}
		}

		public virtual int GetBlockSize()
		{
			return default(int);
		}

		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return default(int);
		}

		public virtual void Reset()
		{
		}

		private void SetKey(byte[] key)
		{
		}

		private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return default(int);
		}

		private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return default(int);
		}

		private long RotateLeft(long x, long y)
		{
			return default(long);
		}

		private long RotateRight(long x, long y)
		{
			return default(long);
		}

		private long BytesToWord(byte[] src, int srcOff)
		{
			return default(long);
		}

		private void WordToBytes(long word, byte[] dst, int dstOff)
		{
		}
	}
}
