namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class DesParameters : KeyParameter
	{
		public const int DesKeyLength = 8;

		private const int N_DES_WEAK_KEYS = 16;

		private static readonly byte[] DES_weak_keys;

		public DesParameters(byte[] key)
		{
		}

		public DesParameters(byte[] key, int keyOff, int keyLen)
		{
		}

		public static bool IsWeakKey(byte[] key, int offset)
		{
			return default(bool);
		}

		public static bool IsWeakKey(byte[] key)
		{
			return default(bool);
		}

		public static byte SetOddParity(byte b)
		{
			return default(byte);
		}

		public static void SetOddParity(byte[] bytes)
		{
		}

		public static void SetOddParity(byte[] bytes, int off, int len)
		{
		}
	}
}
