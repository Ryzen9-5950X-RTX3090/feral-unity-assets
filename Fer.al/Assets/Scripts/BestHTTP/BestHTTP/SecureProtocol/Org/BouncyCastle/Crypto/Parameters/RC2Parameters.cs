namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class RC2Parameters : KeyParameter
	{
		private readonly int bits;

		public int EffectiveKeyBits
		{
			get
			{
				return default(int);
			}
		}

		public RC2Parameters(byte[] key)
		{
		}

		public RC2Parameters(byte[] key, int keyOff, int keyLen)
		{
		}

		public RC2Parameters(byte[] key, int bits)
		{
		}

		public RC2Parameters(byte[] key, int keyOff, int keyLen, int bits)
		{
		}
	}
}
