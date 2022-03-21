namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
{
	public class GOfbBlockCipher : IBlockCipher
	{
		private byte[] IV;

		private byte[] ofbV;

		private byte[] ofbOutV;

		private readonly int blockSize;

		private readonly IBlockCipher cipher;

		private bool firstStep;

		private int N3;

		private int N4;

		private const int C1 = 16843012;

		private const int C2 = 16843009;

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

		public GOfbBlockCipher(IBlockCipher cipher)
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

		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return default(int);
		}

		public void Reset()
		{
		}

		private int bytesToint(byte[] inBytes, int inOff)
		{
			return default(int);
		}

		private void intTobytes(int num, byte[] outBytes, int outOff)
		{
		}
	}
}
