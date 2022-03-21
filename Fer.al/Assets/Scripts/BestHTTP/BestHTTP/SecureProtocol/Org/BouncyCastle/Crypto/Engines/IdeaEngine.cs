namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class IdeaEngine : IBlockCipher
	{
		private const int BLOCK_SIZE = 8;

		private int[] workingKey;

		private static readonly int MASK;

		private static readonly int BASE;

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

		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public virtual int GetBlockSize()
		{
			return default(int);
		}

		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return default(int);
		}

		public virtual void Reset()
		{
		}

		private int BytesToWord(byte[] input, int inOff)
		{
			return default(int);
		}

		private void WordToBytes(int word, byte[] outBytes, int outOff)
		{
		}

		private int Mul(int x, int y)
		{
			return default(int);
		}

		private void IdeaFunc(int[] workingKey, byte[] input, int inOff, byte[] outBytes, int outOff)
		{
		}

		private int[] ExpandKey(byte[] uKey)
		{
			return null;
		}

		private int MulInv(int x)
		{
			return default(int);
		}

		private int AddInv(int x)
		{
			return default(int);
		}

		private int[] InvertKey(int[] inKey)
		{
			return null;
		}

		private int[] GenerateWorkingKey(bool forEncryption, byte[] userKey)
		{
			return null;
		}
	}
}
