namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
{
	public class BufferedStreamCipher : BufferedCipherBase
	{
		private readonly IStreamCipher cipher;

		public override string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public BufferedStreamCipher(IStreamCipher cipher)
		{
		}

		public override void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public override int GetBlockSize()
		{
			return default(int);
		}

		public override int GetOutputSize(int inputLen)
		{
			return default(int);
		}

		public override int GetUpdateOutputSize(int inputLen)
		{
			return default(int);
		}

		public override byte[] ProcessByte(byte input)
		{
			return null;
		}

		public override int ProcessByte(byte input, byte[] output, int outOff)
		{
			return default(int);
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

		public override byte[] DoFinal(byte[] input, int inOff, int length)
		{
			return null;
		}

		public override void Reset()
		{
		}
	}
}
