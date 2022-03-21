namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
{
	public class OpenPgpCfbBlockCipher : IBlockCipher
	{
		private byte[] IV;

		private byte[] FR;

		private byte[] FRE;

		private readonly IBlockCipher cipher;

		private readonly int blockSize;

		private int count;

		private bool forEncryption;

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

		public OpenPgpCfbBlockCipher(IBlockCipher cipher)
		{
		}

		public IBlockCipher GetUnderlyingCipher()
		{
			return null;
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

		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		private byte EncryptByte(byte data, int blockOff)
		{
			return default(byte);
		}

		private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return default(int);
		}

		private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			return default(int);
		}
	}
}
