namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class DesEdeParameters : DesParameters
	{
		public const int DesEdeKeyLength = 24;

		private static byte[] FixKey(byte[] key, int keyOff, int keyLen)
		{
			return null;
		}

		public DesEdeParameters(byte[] key)
		{
		}

		public DesEdeParameters(byte[] key, int keyOff, int keyLen)
		{
		}

		public static bool IsWeakKey(byte[] key, int offset, int length)
		{
			return default(bool);
		}

		public new static bool IsWeakKey(byte[] key, int offset)
		{
			return default(bool);
		}

		public new static bool IsWeakKey(byte[] key)
		{
			return default(bool);
		}

		public static bool IsRealEdeKey(byte[] key, int offset)
		{
			return default(bool);
		}

		public static bool IsReal2Key(byte[] key, int offset)
		{
			return default(bool);
		}

		public static bool IsReal3Key(byte[] key, int offset)
		{
			return default(bool);
		}
	}
}
