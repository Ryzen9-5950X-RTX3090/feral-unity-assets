namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
{
	public class KCtrBlockCipher : IStreamCipher, IBlockCipher
	{
		private byte[] IV;

		private byte[] ofbV;

		private byte[] ofbOutV;

		private bool initialised;

		private int byteCount;

		private readonly int blockSize;

		private readonly IBlockCipher cipher;

		public string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public bool IsPartialBlockOkay
		{
			get
			{
				return default(bool);
			}
		}

		public KCtrBlockCipher(IBlockCipher cipher)
		{
		}

		public IBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public int GetBlockSize()
		{
			return default(int);
		}

		public byte ReturnByte(byte input)
		{
			return default(byte);
		}

		public void ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
		{
		}

		protected byte CalculateByte(byte b)
		{
			return default(byte);
		}

		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return default(int);
		}

		public void Reset()
		{
		}

		private void incrementCounterAt(int pos)
		{
		}

		private void checkCounter()
		{
		}
	}
}
