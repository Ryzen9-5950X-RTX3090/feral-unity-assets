namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class IesWithCipherParameters : IesParameters
	{
		private int cipherKeySize;

		public int CipherKeySize
		{
			get
			{
				return default(int);
			}
		}

		public IesWithCipherParameters(byte[] derivation, byte[] encoding, int macKeySize, int cipherKeySize)
		{
		}
	}
}
