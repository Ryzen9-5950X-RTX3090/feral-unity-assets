namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
{
	public class CtsBlockCipher : BufferedBlockCipher
	{
		private readonly int blockSize;

		public CtsBlockCipher(IBlockCipher cipher)
		{
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

		public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			return default(int);
		}

		public override int DoFinal(byte[] output, int outOff)
		{
			return default(int);
		}
	}
}
