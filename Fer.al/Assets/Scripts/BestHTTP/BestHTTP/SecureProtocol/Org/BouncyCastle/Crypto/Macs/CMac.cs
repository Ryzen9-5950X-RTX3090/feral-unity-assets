namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs
{
	public class CMac : IMac
	{
		private const byte CONSTANT_128 = 135;

		private const byte CONSTANT_64 = 27;

		private byte[] ZEROES;

		private byte[] mac;

		private byte[] buf;

		private int bufOff;

		private IBlockCipher cipher;

		private int macSize;

		private byte[] L;

		private byte[] Lu;

		private byte[] Lu2;

		public string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public CMac(IBlockCipher cipher)
		{
		}

		public CMac(IBlockCipher cipher, int macSizeInBits)
		{
		}

		private static int ShiftLeft(byte[] block, byte[] output)
		{
			return default(int);
		}

		private static byte[] DoubleLu(byte[] input)
		{
			return null;
		}

		public void Init(ICipherParameters parameters)
		{
		}

		public int GetMacSize()
		{
			return default(int);
		}

		public void Update(byte input)
		{
		}

		public void BlockUpdate(byte[] inBytes, int inOff, int len)
		{
		}

		public int DoFinal(byte[] outBytes, int outOff)
		{
			return default(int);
		}

		public void Reset()
		{
		}
	}
}
