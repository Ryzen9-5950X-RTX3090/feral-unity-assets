namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
{
	public class BufferedBlockCipher : BufferedCipherBase
	{
		internal byte[] buf;

		internal int bufOff;

		internal bool forEncryption;

		internal IBlockCipher cipher;

		public override string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		protected BufferedBlockCipher()
		{
		}

		public BufferedBlockCipher(IBlockCipher cipher)
		{
		}

		public override void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public override int GetBlockSize()
		{
			return default(int);
		}

		public override int GetUpdateOutputSize(int length)
		{
			return default(int);
		}

		public override int GetOutputSize(int length)
		{
			return default(int);
		}

		public override int ProcessByte(byte input, byte[] output, int outOff)
		{
			return default(int);
		}

		public override byte[] ProcessByte(byte input)
		{
			return null;
		}

		public override byte[] ProcessBytes(byte[] input, int inOff, int length)
		{
			return null;
		}

		public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			return default(int);
		}

		public override byte[] DoFinal()
		{
			return null;
		}

		public override byte[] DoFinal(byte[] input, int inOff, int inLen)
		{
			return null;
		}

		public override int DoFinal(byte[] output, int outOff)
		{
			return default(int);
		}

		public override void Reset()
		{
		}
	}
}
