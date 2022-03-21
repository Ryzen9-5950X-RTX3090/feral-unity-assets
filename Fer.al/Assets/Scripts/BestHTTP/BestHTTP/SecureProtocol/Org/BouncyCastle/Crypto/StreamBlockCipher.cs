namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
{
	public class StreamBlockCipher : IStreamCipher
	{
		private readonly IBlockCipher cipher;

		private readonly byte[] oneByte;

		public string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public StreamBlockCipher(IBlockCipher cipher)
		{
		}

		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public byte ReturnByte(byte input)
		{
			return default(byte);
		}

		public void ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
		}

		public void Reset()
		{
		}
	}
}
