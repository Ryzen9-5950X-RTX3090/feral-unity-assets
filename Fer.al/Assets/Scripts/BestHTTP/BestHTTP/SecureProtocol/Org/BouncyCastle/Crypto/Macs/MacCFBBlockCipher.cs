namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs
{
	internal class MacCFBBlockCipher : IBlockCipher
	{
		private byte[] IV;

		private byte[] cfbV;

		private byte[] cfbOutV;

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

		public MacCFBBlockCipher(IBlockCipher cipher, int bitBlockSize)
		{
		}

		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public int GetBlockSize()
		{
			return default(int);
		}

		public int ProcessBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return default(int);
		}

		public void Reset()
		{
		}

		public void GetMacBlock(byte[] mac)
		{
		}
	}
}
