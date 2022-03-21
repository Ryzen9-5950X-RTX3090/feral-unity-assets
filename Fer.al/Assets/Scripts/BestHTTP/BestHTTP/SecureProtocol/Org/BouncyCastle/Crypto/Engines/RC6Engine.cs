namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class RC6Engine : IBlockCipher
	{
		private static readonly int wordSize;

		private static readonly int bytesPerWord;

		private static readonly int _noRounds;

		private int[] _S;

		private static readonly int P32;

		private static readonly int Q32;

		private static readonly int LGW;

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

		private int RotateLeft(int x, int y)
		{
			return default(int);
		}

		private int RotateRight(int x, int y)
		{
			return default(int);
		}

		private int BytesToWord(byte[] src, int srcOff)
		{
			return default(int);
		}

		private void WordToBytes(int word, byte[] dst, int dstOff)
		{
		}
	}
}
