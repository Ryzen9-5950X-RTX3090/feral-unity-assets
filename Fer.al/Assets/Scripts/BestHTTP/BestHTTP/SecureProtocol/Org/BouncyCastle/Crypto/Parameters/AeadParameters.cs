namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public sealed class AeadParameters : ICipherParameters
	{
		private readonly byte[] associatedText;

		private readonly byte[] nonce;

		private readonly KeyParameter key;

		private readonly int macSize;

		public KeyParameter Key
		{
			get
			{
				return null;
			}
		}

		public int MacSize
		{
			get
			{
				return default(int);
			}
		}

		public AeadParameters(KeyParameter key, int macSize, byte[] nonce)
		{
		}

		public AeadParameters(KeyParameter key, int macSize, byte[] nonce, byte[] associatedText)
		{
		}

		public byte[] GetAssociatedText()
		{
			return null;
		}

		public byte[] GetNonce()
		{
			return null;
		}
	}
}
